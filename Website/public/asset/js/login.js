var firebaseConfig = {
  apiKey: "AIzaSyAivb0VSITU5puY_W7RyFNdW5cnuZ_vyZs",
  authDomain: "proj-c57ab.firebaseapp.com",
  databaseURL: "https://proj-c57ab.firebaseio.com",
  projectId: "proj-c57ab",
  storageBucket: "",
  messagingSenderId: "674418406161",
  appId: "1:674418406161:web:891c580da793771d"
};
firebase.initializeApp(firebaseConfig);


firebase.auth().onAuthStateChanged(function(user) {

  if (user) {
    // User is signed in.

    window.location="/adminpanel";

    }

  var user = firebase.auth().currentUser;

  if(user != null){

    var email_id = user.email;
    window.location="/adminpanel";

  }

  else {
    // No user is signed in.
    document.getElementById("user_div").style.display = "none";
    document.getElementById("login_div").style.display = "block";
  }
});


function login(){

  var userEmail = document.getElementById("email_field").value;
  var userPass = document.getElementById("password_field").value;

  firebase.auth().signInWithEmailAndPassword(userEmail, userPass).catch(function(error) {
    // Handle Errors here.
    var errorCode = error.code;
    var errorMessage = error.message;

    window.alert("Error : " + errorMessage);

    // ...
  });

}
