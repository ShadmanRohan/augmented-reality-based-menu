@extends('adminlayout')

@section('admintopic')
    Current Orders
@endsection

@section('admincontent')
    <!-- ============================================================== -->
    <!-- Start Page Content -->
    <!-- ============================================================== -->
    <div class="row">
        <!-- column -->
        <div class="col-sm-12">
            <div class="card">
                <div class="card-block">
                    <h4 class="card-title">Orders</h4>

                    <div class="table-responsive">

                        <table class="table">

                            <thead>
                            <tr>

                                <th scope="col">Name</th>
                                <th scope="col">Price</th>
                                <th scope="col">Quantity</th>
                                <th scope="col">Table Number</th>
                                <th scope="col">Time</th>
                            </tr>
                            </thead>

                            <tbody>

                            @foreach($all_order as $order)

                                <tr>
                                    <td>{{$order['fname']}}</td>
                                    <td>{{$order['price']}}</td>
                                    <td>{{$order['quantity']}}</td>
                                    <td>{{$order['tableno']}}</td>
                                    <td>{{$order['time']}}</td>
                                </tr>

                            @endforeach

                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End PAge Content -->
    <!-- ============================================================== -->
@endsection
