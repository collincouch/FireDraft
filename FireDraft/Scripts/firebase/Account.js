var fbUsers = new Firebase("https://draftboard.firebaseio.com/Users/");
var rootRef = new Firebase('https://draftboard.firebaseio.com');
var auth;

function LogOut() {
    auth = new Firebase(rootRef);
    auth.unauth();
}


function initializeSimpleLogin(callback) {
    try {
        //console.log('initializeSimpleLogin()');
        auth = new FirebaseSimpleLogin(rootRef, function (error, user) {
            if (error) {
                switch (error.code) {
                    case 'INVALID_EMAIL':
                        console.log(error.code);

                    case 'INVALID_PASSWORD':
                        console.log(error.code);
                    default:
                        console.log(error.code);

                }
                callback(error.code);
            } else if (user) {
                // user authenticated with Firebase
                //email = user.email;
                //console.log('User is authorized: User ID: ' + user.id + ', Email: ' + user.email + ', Provider: ' + user.provider);

                callback(user.email);


            } else {
                //console.log('invalid uid/pwd');
                callback(null);
            }

        });
    }
    catch (e) {
        console.log('error is ' + e);
    }

}


/**
 * Looks up a user id by email address and invokes callback with the id or null if not found
 * return {Object|null} the object contains the key/value hash for one user
 */
function getUserIdByEmail(emailAddress, callback) {
    fbUsers.child('emails_to_ids/' + emailToKey(emailAddress)).once('value', function (snap) {
        callback(snap.val());
    });
}

/**
 * Creates a new user record and also updates the index
 */
function createNewUser(userRecord, email, password, callback) {
    //console.log('createNewUser ' + email + ' '  + password);

    var userEmail = email.toLowerCase();
    var userPwd = password;
    try {
        //console.log('fbUsers Path ' + fbUsers.toString());
        //console.log('userRecord ' + JSON.stringify(userRecord));
        var uid = fbUsers.child('user').push(userRecord, function (err) {

            if (!err) {
                //console.log('fbUsers Path ' + fbUsers.toString());
                fbUsers.child('emails_to_ids/' + emailToKey(userRecord.Email)).set(uid, function (err) {
                    if (!err) {
                        //console.log('createNewUser ' + userEmail + ' ' + userPwd);
                        auth.login('password', {
                            email: userEmail,
                            password: userPwd
                        });
                        callback(uid);

                    }
                });
            }


        }).name();




    }
    catch (e) {
        console.log(e);
    }

}

/**
 * Firebase keys cannot have a period (.) in them, so this converts the emails to valid keys
 */
function emailToKey(emailAddress) {
    return emailAddress.replace('.', ',');
}