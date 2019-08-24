@extends('layout')

@section('content')



    <div class="container">
        <div class="row" id="Reservation">
            <div class="col navMenu">
                <h2 class="text-center" >~ Reservation ~</h2>
            </div>
        </div>


        <!--- Start of Reservation-->
    <div class="row">
        <div class=" col-lg-12 reserve-container" data-aos="fade-up">
            <img class="img-fluid image-reserve" src="../asset/images/reserve.jpg">
            <div class="reserve-text col-lg-12 ">
                <h1 class="text-center">Timetables</h1>
                <div class="row">
                    <div class="col-6">
                        <h2 class="text-center">Lunch</h2>
                        <h5 class="text-center">12:00 - 15:00</h5>
                    </div>
                    <div class="col-6">
                        <h2 class="text-center">Dinner</h2>
                        <h5 class="text-center">19:30 - 23:30</h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br>
    <div class="row bg-light">
        <div class="col">
            <form id="contactForm">
                <div class="form-row">

                    <div class="form-group col-6">
                        <h3>Reserve</h3>
                        <label for="inputDate"> Date</label>
                        <input type="date" class="form-control" id="inputDate" placeholder="Data gg/mm/aaaa">
                    </div>

                    <div class="form-group col-6">
                        <h3>Details</h3>
                        <label for="inputName"> Name</label>
                        <input type="text" class="form-control" id="inputName" placeholder="Name" required>
                    </div>

                    <div class="form-group col-6">
                        <label for="inputTime"> Timetables</label>
                        <input type="time" class="form-control" id="inputTime" placeholder="Timetables" required>
                    </div>

                    <div class="form-group col-6">
                        <label for="inputEmail"> Email</label>
                        <input type="email" class="form-control" id="inputEmail" placeholder="Email" required>
                    </div>

                    <div class="form-group col-6">
                        <label for="inputNumber"> Number of Guests</label>
                        <input type="number" class="form-control" id="inputNumber" placeholder="Number of Guests" required>
                    </div>

                    <div class="form-group col-6">
                        <label for="inputCel"> Phone</label>
                        <input type="tel" class="form-control" id="inputCel" placeholder="Phone" required>
                    </div>

                    <div class="form-group col-12">
                        <label for="inputComment"> Further requests</label>
                        <textarea class="form-control" rows="4" id="inputComment" placeholder="Further requests"></textarea>
                    </div>

                </div>
                <div class="row">
                    <div class="col-md-4 col-md-offset-4">
                        <button type="submit" class="btn btn-secondary btn-block">Reserve</button>
                    </div>
                </div>
            </form>
        </div>
    </div>



    <!--- End of Reserve -->
        <script src="https://www.gstatic.com/firebasejs/6.3.5/firebase.js"></script>

        <script src="../asset/js/reserve.js"></script>

@endsection
