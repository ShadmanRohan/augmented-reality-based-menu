
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

function logout(){
    firebase.auth().signOut();
    window.location ="/welcome";

}