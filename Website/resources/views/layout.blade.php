<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="../asset/css/style.css">
    <link href='https://fonts.googleapis.com/css?family=Merienda' rel='stylesheet'>
    <link href="https://cdn.rawgit.com/michalsnik/aos/2.1.1/dist/aos.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Nunito:400,600,700" rel="stylesheet">
    <link rel="stylesheet" href="../asset/css/login.css" />



    <title>Food House</title>
    <link rel="icon" href="../asset/images/logo.png">
</head>

<body data-spy="scroll" data-target=".navbar" data-offset="50">
<div id="Welcome">

    <!---Start navigation Bar -->
    <nav class="navbar navbar-expand-lg navbar fixed-top  navbar-light bg-light">
        <a class="navbar-brand" href="#Welcome">
            <img src="../asset/images/logo1.png" width="130" height="50" class="d-inline-block" alt="">
        </a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarText">
            <ul class="navbar-nav ml-auto">
                <li class="nav-item">
                    <a class="nav-link" href="/welcome">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/menu">Menu</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/reservation">Reservation</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/login">Admin panel</a>
                </li>
                <li class="nav-item">
                    <a href="/welcome" class="language" rel="it-IT"><img src="../asset/images/italy.ico" class="flag" alt="Italiano"></a>
                    <a href="/welcome" class="language" rel="en-En"><img src="../asset/images/english.ico" class="flag" alt="English"></a>
                </li>
            </ul>
        </div>
    </nav>
    <!--- End Navigation Bar -->

    @yield('content')





<!- =================================================== All js Files ==================================>
<script src="../asset/js/jquery-3.3.1.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
<script defer src="https://use.fontawesome.com/releases/v5.0.6/js/all.js"></script>
<script type="text/javascript" src="../asset/js/map.js"></script>
<script type="text/javascript" src="../asset/js/smooth-scroll.js"></script>
<script src="https://cdn.rawgit.com/michalsnik/aos/2.1.1/dist/aos.js"></script>
<script type="text/javascript" src="../asset/js/image-effect.js"></script>
<script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDFZjOV0KA68G2YAh-rn7I3qKqCQEh_Ja0&callback=myMap"></script>

    <script src="https://www.gstatic.com/firebasejs/4.8.1/firebase.js"></script>
    <script src="../asset/js/login.js"></script>




</div>
</body>
</html>

