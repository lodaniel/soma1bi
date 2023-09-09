use std::time::{Instant};

fn main() {
    let mut tot: u64 = 0;
    let n: u64 = 1_000_000_000;
    let ti = Instant::now();
    for i in 1..=n {tot += i;}
    let tf = Instant::now();
    let dt = tf.duration_since(ti);
    println!("Soma: {}", tot);
    println!("Tempo: {:.15}", dt.as_secs_f64());
}