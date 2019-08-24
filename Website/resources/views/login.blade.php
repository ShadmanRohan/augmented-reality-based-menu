@extends('layout')

@section('content')

<div id="login_div" class="main-div">
    <h3><center>Welcome</center></h3>
    <input type="email" placeholder="Username" id="email_field" />
    <input type="password" placeholder="Password" id="password_field" />

    <button onclick="login()">Login to Account</button>
</div>

<div id="user_div" class="loggedin-div">
    <h3>Welcome User</h3>
    <p id="user_para">Welcome to Firebase web login Example. You're currently logged in.</p>
    <button onclick="logout()">Logout</button>
</div>



@endsection