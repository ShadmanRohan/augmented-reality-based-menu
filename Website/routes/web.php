<?php
/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('/welcome', function () {
    return view('welcome');
});

Route::get('/menu', function () {
    return view('menu');
});

Route::get('/reservation', function () {
    return view('reservation');
});

Route::get('/admin', function () {
    return view('admin');
});

Route::get('/login', function () {
    return view('login');
});




Route::get('/adminpanel', function () {
    return view('adminpanel');
});

Route::get('/sales-history', function () {
    return view('sales-history');
});




Route::get('/reserve', 'fireBController@showReserve')->name('reserve');
Route::get('/item', 'fireBController@showItem')->name('item');
Route::get('/order', 'fireBController@showOrders')->name('order');

//Route::get('/updatestock/{itemid}', 'fireBController@updateStock');

