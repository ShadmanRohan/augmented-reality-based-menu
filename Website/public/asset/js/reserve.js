// Initialize Firebase (ADD YOUR OWN DATA)
var firebaseConfig = {
    apiKey: "AIzaSyAvoPGvaK2Wm-_7iK8izDZdwED-4WD_Jb4",
    authDomain: "cse327-ec9ea.firebaseapp.com",
    databaseURL: "https://cse327-ec9ea.firebaseio.com",
    projectId: "cse327-ec9ea",
    storageBucket: "cse327-ec9ea.appspot.com",
    messagingSenderId: "26076153587",
    appId: "1:26076153587:web:702c2d091ddb24b7"
};
// Initialize Firebase
firebase.initializeApp(firebaseConfig);


// Reference messages collection
var messagesRef = firebase.database().ref("Reservation");

// Listen for form submit
document.getElementById('contactForm').addEventListener('submit', submitForm);

// Submit form
function submitForm(e){
    e.preventDefault();

    // Get values
    var Name = getInputVal('inputName');
    var Email = getInputVal('inputEmail');
    var Phone = getInputVal('inputCel');
    var Date = getInputVal('inputDate');
    var Timetables = getInputVal('inputTime');
    var Number_of_Guests = getInputVal('inputNumber');

    // Save message
    saveMessage(Name, Email, Phone, Date, Timetables, Number_of_Guests);


    // Clear form
    document.getElementById('contactForm').reset();
}


// Function to get form values
function getInputVal(id){
    return document.getElementById(id).value;
}

// Save message to firebase
function saveMessage(Name, Email, Phone, Date, Timetables, Number_of_Guests){
    var newMessageRef = messagesRef.push();
    newMessageRef.set({
        Name: Name,
        Email:Email,
        Phone:Phone,
        Date:Date,
        Timetables:Timetables,
        Number_of_Guests:Number_of_Guests
    });
}

