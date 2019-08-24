@extends('adminlayout')

@section('admintopic')
    Table
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
                    <h4 class="card-title">Reservation</h4>
                    <div class="table-responsive">
                        <table class="table">

                            <thead>
                            <tr>


                                <th scope="col">Name</th>
                                <th scope="col">Email</th>
                                <th scope="col">Phone</th>
                                <th scope="col">Date</th>
                                <th scope="col">Timetables</th>
                                <th scope="col">Number of Guests</th>

                            </tr>
                            <thead>

                            <tbody>
                            <!-- Showing in table format -->
                            @foreach ($all_reserve as $reserve)

                                <tr>

                                    <td>{{$reserve['Name']}}</td>
                                    <td>{{$reserve['Email']}}</td>
                                    <td>{{$reserve['Phone']}}</td>
                                    <td>{{$reserve['Date']}}</td>
                                    <td>{{$reserve['Timetables']}}</td>
                                    <td>{{$reserve['Number_of_Guests']}}</td>
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
    <script src="https://www.gstatic.com/firebasejs/6.3.5/firebase.js"></script>
    <script src="../asset/js/adminreserve.js"></script>
@endsection
