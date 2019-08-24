<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Kreait\Firebase;
use Kreait\Firebase\Factory;
use Kreait\Firebase\ServiceAccount;
use Kreait\Firebase\Database;

class fireBController extends Controller
{

    //Showing Customer Reservation Page

    public function showReserve()
    {
        $serviceAccount = ServiceAccount::fromJsonFile(__DIR__ . '/cse327-ec9ea-firebase-adminsdk-hefrs-4152589af7.json');
        $firebase = (new Factory)
            ->withServiceAccount($serviceAccount)
            ->withDatabaseUri('https://cse327-ec9ea.firebaseio.com/')
            ->create();

        $database = $firebase->getDatabase();

        $ref = $database->getReference('Reservation');

        $reserves = $ref->getvalue();

        foreach ($reserves as $reserve) {
            $all_reserve[] = $reserve;

        }
        return view('adminreserve', compact('all_reserve') );
    }


    //Showing Stock Page

    public function showItem()
    {
        $serviceAccount = ServiceAccount::fromJsonFile(__DIR__ . '/cse327-ec9ea-firebase-adminsdk-hefrs-4152589af7.json');
        $firebase = (new Factory)
            ->withServiceAccount($serviceAccount)
            ->withDatabaseUri('https://cse327-ec9ea.firebaseio.com/')
            ->create();

        $database = $firebase->getDatabase();

        $refs = $database->getReference('Item');
        $items = $refs->getvalue();

        foreach ($items as $item) {
            $all_item[] = $item;
        }
        return view('stock', compact('all_item') );
    }


    //Showing Current Orders Page

    public function showOrders()
    {
        $serviceAccount = ServiceAccount::fromJsonFile(__DIR__ . '/cse327-ec9ea-firebase-adminsdk-hefrs-4152589af7.json');
        $firebase = (new Factory)
            ->withServiceAccount($serviceAccount)
            ->withDatabaseUri('https://cse327-ec9ea.firebaseio.com/')
            ->create();
        $database = $firebase->getDatabase();
        $refs = $database->getReference('Order_Items');

        $orders = $refs->getvalue();

        foreach ($orders as $order) {
            $all_order[] = $order;
        }
        return view('current-orders', compact('all_order') );
    }





}
