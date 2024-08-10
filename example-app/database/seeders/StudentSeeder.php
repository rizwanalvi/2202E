<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use App\Models\Student;
class StudentSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        //
        Student::Create(
            [
                'stdname'=>'Seederuser',
                "batchid"=>'2505E',
                "course"=>'CPISM'
            ]
        );
        Student::Create(
            [
                'stdname'=>'Seederuser01',
                "batchid"=>'2505E',
                "course"=>'CPISM'
            ]
        );
    }
}
