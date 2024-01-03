use std::io::{stdin, stdout, Write};

struct Student {
    name: String,
    grades: Vec<u8>,
    avg: f64,
}

fn read_data() -> Vec<Student> {
    return std::fs::read_to_string("adatok.csv")
        .expect("Failed to read file")
        .lines()
        .map(|line| {
            let mut parts = line.split(';');

            let name = parts.next().expect("Empty name").to_string();
            let grades: Vec<u8> = parts
                .map(|grade| grade.parse().expect("Invalid grade"))
                .collect();
            let avg = grades.iter().sum::<u8>() as f64 / grades.len() as f64;

            return Student { name, grades, avg };
        })
        .collect();
}

fn lowest_avg<'a>(data: &'a Vec<Student>) -> &'a Student {
    return data
        .iter()
        .min_by(|&a, &b| a.avg.partial_cmp(&b.avg).expect("Invalid data"))
        .expect("Empty data");
}

fn highest_avg<'a>(data: &'a Vec<Student>) -> &'a Student {
    return data
        .iter()
        .max_by(|&a, &b| a.avg.partial_cmp(&b.avg).expect("Invalid data"))
        .expect("Empty data");
}

fn avg_per_subject(data: &Vec<Student>) -> Vec<f64> {
    let mut averages = vec![0.0; data.first().expect("Empty data").grades.len()];

    for student in data {
        for (i, grade) in student.grades.iter().enumerate() {
            averages[i] += *grade as f64;
        }
    }

    for avg in averages.iter_mut() {
        *avg /= data.len() as f64;
    }

    return averages;
}

fn count_excellent(data: &Vec<Student>) -> usize {
    return data
        .iter()
        .flat_map(|student| &student.grades)
        .filter(|&grade| grade == &5)
        .count();
}

fn count_above_avg_per_subject(data: &Vec<Student>, avg_per_subject: Vec<f64>) -> Vec<usize> {
    let mut counts = vec![0; avg_per_subject.len()];

    for student in data {
        for (i, grade) in student.grades.iter().enumerate() {
            if *grade as f64 > avg_per_subject[i] {
                counts[i] += 1;
            }
        }
    }

    return counts;
}

fn count_better_in_maths_then_previous(data: &Vec<Student>) -> u8 {
    return data.windows(2).fold(0, |acc, students| {
        if students[1].grades[1] > students[0].grades[1] {
            return acc + 1;
        }

        return acc;
    });
}

fn students_with_specific_grade(data: &Vec<Student>) -> Vec<&Student> {
    let mut query = 0;

    while query < 1 || query > 5 {
        print!("Enter grade a (1-5): ");
        stdout().flush().expect("Failed to flush stdout");

        let mut buffer = String::new();
        stdin().read_line(&mut buffer).expect("Failed to read line");

        if let Ok(num) = buffer.trim().parse() {
            query = num;
        }
    }

    return data
        .iter()
        .filter(|student| student.grades.contains(&query))
        .collect();
}

fn students_who_failed(data: &Vec<Student>) -> Vec<&Student> {
    return data
        .iter()
        .filter(|student| student.grades.contains(&1))
        .collect();
}

fn main() {
    let data = read_data();

    println!("2: {}", data.len());

    println!(
        "\n3:\n{}",
        data.iter()
            .map(|student| format!("{}: {:.2}", student.name, student.avg))
            .collect::<Vec<_>>()
            .join("\n")
    );

    println!("\n4: {}", lowest_avg(&data).name);
    println!("5: {}", highest_avg(&data).name);

    let avg_per_subject = avg_per_subject(&data);
    println!("6: {:?}", avg_per_subject);

    println!("7: {}", count_excellent(&data));

    println!(
        "8: {:?}",
        count_above_avg_per_subject(&data, avg_per_subject)
    );

    println!("9: {}", count_better_in_maths_then_previous(&data));

    println!("\n10:");
    println!(
        "{}",
        students_with_specific_grade(&data)
            .iter()
            .map(|student| student.name.to_string())
            .collect::<Vec<_>>()
            .join("\n")
    );

    println!("\n11:");
    for student in students_who_failed(&data) {
        println!(
            "{:<20} {:>15} {:>15} {:>15} {:>15} {:>15} {:>15}",
            student.name,
            student.grades[0],
            student.grades[1],
            student.grades[2],
            student.grades[3],
            student.grades[4],
            student.avg
        );
    }
}
