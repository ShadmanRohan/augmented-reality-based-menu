@extends('adminlayout')

@section('admintopic')
    Stock
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
                    <h4 class="card-title">Stock</h4>

                    <div class="table-responsive">

                        <table class="table">

                            <thead>
                            <tr>

                                <th scope="col">ID</th>
                                <th scope="col">Name</th>
                                <th scope="col">Price</th>
                                <th scope="col">Stock</th>
                          <!--      <th scope="col">Refill</th>   --!>

                            </tr>
                            </thead>

                            <tbody>
                            <!-- Showing in table format -->
                            @foreach($all_item as $item)

                                <tr>
                                    <td>{{$item['itemid']}}</td>
                                    <td>{{$item['fname']}}</td>
                                    <td>{{$item['price']}}</td>
                                    <td>{{$item['stock']}}</td>
                                <!--   <td><a href="/updatestock/{{$item['itemid']}}" class="btn btn-success"> ADD </a> </td>   --!>

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
