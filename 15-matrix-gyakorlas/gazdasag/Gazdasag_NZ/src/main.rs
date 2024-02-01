use std::collections::HashSet;

type Grid = Vec<Vec<char>>;

fn main() {
    let data = read_data();
    let height = data.len();
    let width = data[0].len();
    let area = width * height;

    println!(
        "2. feladat: {}m x {}m, területe: {}ha",
        height * 100,
        width * 100,
        area
    );

    println!("3. feladat: {:.2}%", pasture_percentage(&data, area));
    println!("4. feladat: {}m", distance_from_north_side(&data) * 100);
    println!("5. feladat: {}m", widest_pasture(&data) * 100);
    println!("6. feladat: {}db", count_pastures(&data));
    println!("7. feladat: {}ha", biggest_pasture(&data));
}

fn read_data() -> Grid {
    return std::fs::read_to_string("terulet.txt")
        .expect("Failed to read file")
        .lines()
        .map(|line| line.chars().collect())
        .collect();
}

fn pasture_percentage(data: &Grid, area: usize) -> f64 {
    let pasture_count = data.iter().flatten().filter(|&&c| c == 'L').count();
    return pasture_count as f64 / area as f64 * 100.0;
}

fn distance_from_north_side(data: &Grid) -> usize {
    return data
        .iter()
        .position(|row| row.contains(&'L'))
        .expect("Invalid input, no pastures found");
}

fn widest_pasture(data: &Grid) -> usize {
    let mut max_width = 0;
    let mut current_width = 0;

    for row in data {
        for &item in row {
            if item == 'L' {
                current_width += 1;
                continue;
            }

            max_width = max_width.max(current_width);
            current_width = 0;
        }
    }
    return max_width;
}

fn count_pastures(data: &Grid) -> usize {
    let mut count = 0;

    for (y, row) in data.iter().enumerate() {
        for (x, &item) in row.iter().enumerate() {
            if item == 'L' && (data[y - 1][x] != 'L') && (row[x - 1] != 'L') {
                count += 1;
            }
        }
    }

    return count;
}

fn biggest_pasture(data: &Grid) -> usize {
    let mut seen = HashSet::new();
    let mut max_area = 0;

    for (y, row) in data.iter().enumerate() {
        for (x, &item) in row.iter().enumerate() {
            if item != 'L' || seen.contains(&(y, x)) {
                continue;
            }

            seen.insert((y, x));

            let mut i = x;
            while data[y][i] == 'L' {
                seen.insert((y, x));
                i += 1;
            }

            let width = i - x;

            i = y;
            while data[i][x] == 'L' {
                seen.insert((i, x));
                i += 1;
            }

            max_area = max_area.max(width * (i - y));
        }
    }

    return max_area;
}
