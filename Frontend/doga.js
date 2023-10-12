const tomb1 = [16, 91, 45, 69, 82, 26, 46, 21, 22, 11]
console.log(tomb1);
console.log(tomb1.sort(function(a,b){return a-b}))
console.log(tomb1.sort(function(a,b){return b-a}))
tomb1.shift();
tomb1.pop();
console.log(tomb1);
tomb1.unshift(77, 89);


//2.feladat
function tantargy(nev, oktatoja, hely, koltseg){
this.nev = nev;
this.oktatoja = oktatoja;
this.hely = hely;
this.koltseg = koltseg;
}

const frontend = new tantargy("Frontend", "Németh Bence", "A313 terem", 8272376)
const Asztali = new tantargy("Asztali alkalmazás", "Kis Roland", "A313 terem", 8376)
console.log(frontend);
console.log(Asztali);

frontend.oktatoja = "Négyesi Gábor";
console.log(frontend);

Asztali.koltseg = 282734;
console.log(Asztali);

//3.feladat
const országok = ["Magyar", "Német", "Anglia", "Francia", "Orosz"];
const keys = Object.keys(országok);

let text = "";
for (let x of keys) {
  text += x + "\t";
}
console.log(text)

//4.feladat
let nevek = {
    András: {
       összesen:800,
       kiadás:600,
       bevétel:2500
    },
    Béla: {
        összesen:900,
        kiadás:700,
        bevétel:2000
    },
    Andrea: {
        összesen:600,
        kiadás:900,
        bevétel:1000
    },
    Ferenc: {
        összesen:400,
        kiadás:300,
        bevétel:2100
    }
}

nevek.Marianna = {összesen:200,kiadás:100,bevétel:1100};
console.table(nevek);

//5.feladat
let allatok = new Map();

allatok.set("Kutya", 5);
allatok.set("Macska", 3);
allatok.set("Papagáj", 8);
allatok.set("Tengerimalac", 4);
allatok.set("Menyét", 6);
allatok.set("Pók", 7);

console.log(allatok instanceof Map)
console.log(typeof allatok);
console.log("A Map mérete: " + allatok.size);

allatok.delete("Pók")
allatok.clear();


