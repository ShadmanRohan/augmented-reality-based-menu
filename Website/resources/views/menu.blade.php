@extends('layout')

@section('content')
    <!--- Start of Menu-->
    <div class="container">
        <div class="row" id="menu">
            <div class="col navMenu">
                <h2 class="text-center" >~ Orders ~</h2>
            </div>
        </div>


    <div class="row bg-light">
        <div class="col-md-4" data-aos="slide-up">
            <div class="card view zoom">
                <img class="card-img-top img-fluid " src="../asset/images/meat-menu.jpg">
                <div class="card-body">
                    <h5 class="card-title">~ Meat Menu ~</h5>
                    <ul class="list-group list-group-flush">
                        <li class="list-group-item">Bocconcini di carne in nido di sfoglia</li>
                        <li class="list-group-item">Bruschette con maiale al curry</li>
                        <li class="list-group-item">Uova al prosciutto</li>
                        <li class="list-group-item">Vitello tonnato</li>
                        <li class="list-group-item">Fesa di tacchino marinata con olive</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="col-md-4" data-aos="slide-up">
            <div class="card">
                <img class="card-img-top img-fluid " src="../asset/images/fish-menu.jpg">
                <div class="card-body">
                    <h5 class="card-title">~ Fish Menu ~</h5>
                    <ul class="list-group list-group-flush">
                        <li class="list-group-item">Carpaccio di polpo</li>
                        <li class="list-group-item">Cozze al verde</li>
                        <li class="list-group-item">Cocktail di gamberi</li>
                        <li class="list-group-item">Risotto alla crema di scampi</li>
                        <li class="list-group-item">Ravioli di pesce con crema di scampi</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="col-md-4" data-aos="slide-up">
            <div class="card">
                <img class="card-img-top img-fluid" src="../asset/images/menu-vegetarian.jpg">
                <div class="card-body">
                    <h5 class="card-title">~ Vegetarian Menu ~</h5>
                    <ul class="list-group list-group-flush">
                        <li class="list-group-item">Parmigiana di melanzane</li>
                        <li class="list-group-item">Strudel con ricotta e spinaci</li>
                        <li class="list-group-item">Polpette di spinaci e ricotta</li>
                        <li class="list-group-item">Frittata di patate al forno</li>
                        <li class="list-group-item">Spaghetti con le polpettine vegetariane</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!--- End of Menu -->

@endsection
