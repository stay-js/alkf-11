#[path = "../constants/mod.rs"]
mod constants;

use constants::{first_names::FIRST_NAMES, last_names::LAST_NAMES};
use rand::{seq::SliceRandom, Rng};
use std::{fs, path::Path};

const NUMBER_OF_STUDENTS: usize = 250;
const NUMBER_OF_SUBJECTS: usize = 5;

fn main() {
    let mut rng = rand::thread_rng();

    let data: Vec<_> = (0..NUMBER_OF_STUDENTS)
        .map(|_| {
            let first_name = FIRST_NAMES.choose(&mut rng).expect("Empty first names");
            let last_name = LAST_NAMES.choose(&mut rng).expect("Empty last names");

            let grades = (0..NUMBER_OF_SUBJECTS)
                .map(|_| rng.gen_range(1..=5).to_string())
                .collect::<Vec<_>>();

            return format!("{} {};{}", first_name, last_name, grades.join(";"));
        })
        .collect();

    fs::write("adatok.csv", data.join("\n")).expect("Failed to write file");

    if Path::new("../csharp/AsztaliProjekt").exists() {
        fs::copy("adatok.csv", "../csharp/AsztaliProjekt/adatok.csv")
            .expect("Failed to copy file to C# project");
    }
}
