<?php

namespace App\Http\Controllers;

use App\Models\Student;
use Illuminate\Http\Request;

class StudentController extends Controller
{
    /**
     * Display a listing of the resource.
     */
   public  function __construct(){

        $this->middleware('auth');
    }
    public function index()
    {
        //
        $student = Student::all();
        return view('student.index')->with('student',$student);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        //
        return view('student.create');
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        //
        Student::create($request->all());
        return redirect('/student');
    }

    /**
     * Display the specified resource.
     */
    public function show(Student $student)
    {
        //
        return view('student.show')->with("item",$student);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Student $student)
    {
        //
        return view('student.edit')->with("item",$student);;
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, Student $student)
    {
        //
        //var_dump($request->all());
        $abc = Student::find($student->id);
        
        $abc->stdname = $request->input('stdname');
        $abc->batchid = $request->input('batchid');
        $abc->course = $request->input('course');
        $abc->save();
     return redirect('/student');


    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Student $student)
    {
        //
        //$abc = Student::find($student->id);
       Student::destroy($student);
       
        return redirect('/student');

    }
}
