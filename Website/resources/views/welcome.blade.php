
@extends('layout')

@section('content')

        <!--- Start Carousel -->
        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                <ol class="carousel-indicators">
                        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                </ol>
                <div class="carousel-inner">
                        <div class="carousel-item active">
                                <img class="d-block w-100 img-fluid img-slider" src="../asset/images/slider1.jpg" alt="First slide">
                                <div class="carousel-caption">
                                        <h2>Welcome!</h2>
                                        <p>...</p>
                                </div>
                        </div>
                        <div class="carousel-item">
                                <img class="d-block w-100 img-fluid img-slider" src="../asset/images/slider2.jpg" alt="Second slide">
                                <div class="carousel-caption">
                                        <h2>Traditional Italian Cuisine</h2>
                                        <p>...</p>
                                </div>
                        </div>
                        <div class="carousel-item">
                                <img class="d-block w-100 img-fluid img-slider" src="../asset/images/slider3.jpg" alt="Third slide">
                                <div class="carousel-caption">
                                        <h2>Selected Products</h2>
                                        <p>...</p>
                                </div>
                        </div>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                </a>
        </div>
        </div>
        <!--- End of Carousel -->

        <!--- Restaurant-->
        <div class="container">
                <div class="row" id="Restaurant">
                        <div class="col navMenu">
                                <h2 class="text-center" >~ Restaurant ~</h2>
                        </div>
                </div>
                <div class="row bg-light" >
                        <div class="col-md-6">
                                <h3>Location</h3>
                                <p>Thanks for stopping by. We are the last authentic Italian restaurant in Milan, serving delicious Italian cuisine cooked by the best chefs. It only takes a few minutes to browse through our website and check out our menu. We hope you'll soon join us for a superb Italian culinary experience.</p>
                                <h5>A Unique Experience</h5>
                                <p>Thanks for stopping by. We are the last authentic Italian restaurant in Milan, serving delicious Italian cuisine cooked by the best chefs. It only takes a few minutes to browse through our website and check out our menu. We hope you'll soon join us for a superb Italian culinary experience.</p>
                        </div>
                        <div class="col-md-6" data-aos="fade-up">
                                <img class="img-fluid" src="../asset/images/location.jpg">
                        </div>
                </div>
                <div class="row bg-light"><br></div>
                <div class="row bg-light">
                        <div class="col-md-6 order-md-1 order-2" data-aos="fade-up">
                                <img class="img-fluid " src="../asset/images/cuisine.jpg">
                        </div>
                        <div class="col-md-6 order-md-12 order-1">
                                <h3>Cuisine</h3>
                                <p>Thanks for stopping by. We are the last authentic Italian restaurant in Milan, serving delicious Italian cuisine cooked by the best chefs. It only takes a few minutes to browse through our website and check out our menu. We hope you'll soon join us for a superb Italian culinary experience.</p>
                                <h5>A Unique Experience</h5>
                                <p>Thanks for stopping by. We are the last authentic Italian restaurant in Milan, serving delicious Italian cuisine cooked by the best chefs. It only takes a few minutes to browse through our website and check out our menu. We hope you'll soon join us for a superb Italian culinary experience.</p>
                        </div>
                </div>
                <!--- End of Restaurant -->

@endsection
