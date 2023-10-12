/*var a = "abc";
var b = "def";
console.log(a+b);*/
//console.log(3*4-5/7==1);
/*
tomb2 = [23,32,41,111,5];
tomb2.sort((function(a, b){return a-b}));
console.table(tomb2);
console.log("Legkisebb elem: "+ tomb2[0]);
console.log("Legnagyobb elem: "+ tomb2[tomb2.length-1]);
console.log(tomb2.length);

tomb3 = [23,32,41,111,5];
tomb3.sort((function(a, b){return b-a}));
console.table(tomb3);
console.log("Legnagyobb elem: "+ tomb3[0]);
console.log("Legkisebb elem: "+ tomb3[tomb2.length-1]);
console.log(tomb3.length);
*/

/*
tomb= [1,2,3,4,5];
console.table(tomb);
tomb[5]=6;
tomb.push(5); //-> utolsó elem után bővíti!
console.table(tomb);
tomb.pop();
console.table(tomb);
*/
/*
const fruits = ["Banana", "Orange", "Apple", "Mango"];
console.table(fruits);
fruits.shift();
console.table(fruits);
fruits.unshift("Lemon","Pineapple");
console.table(fruits);
fruits.pop();
console.table(fruits);
*/
/*
tomb3 = [[1, 2, 3], ["a", "b", "c"], ["I", "II","III"]];
console.table(tomb3);
console.log(tomb3[0][2]);
const fruits = ["Banana", "Orange", "Apple", "Mango"];
let text = fruits.toString();
console.log(text)
console.log(text[0])
text += ",xd"
console.log(text)*/
/*
tesiJegyek = [["Aladár",3],["Béla",2],["Cecil",4,5,3,4]];
console.log(tesiJegyek);   

const arr1 = ["Cecilie", "Lone"];
const arr2 = ["Emil", "Tobias", "Linus"];
const children = arr1.concat(arr2);
console.table(children)
*/
/*
const fruits = ["Banán", "Narancs", "Alma", "Mangó"];
let text = fruits.join();
console.log(text)
/*
tesiObjektum = {
    Aladár: 3,
    Béla: 2,
    Cecil: 4,
}
console.log(tesiObjektum.Aladár);
tesiObjektum.Dénes = 5;
console.log(tesiObjektum);
osztaly = {
    Aladár: {
        tesi: 5,
        tori: 5,
        webprogramozas: 1
    },
    Béla: {
        tesi: 4,
        tori: 3,
        webprogramozas: 5
    },
    Cecil: {
        tesi: 3,
        tori: 5,
        webprogramozas: 4
    }
}
console.table(osztaly);
osztaly.Dénes={tesi: 4, tori: 5, webprogramozas: 4};
console.table(osztaly);*/
/*
const fruits = ["Banana", "Orange", "Apple", "Mango"];
const keys = fruits.keys();

let text = "";
for (let x of keys) {
  text += x + "\t";
}
console.log(text)
*/
/*
const fruits = ["Banana", "Orange", "Apple", "Mango"];
const keys = Object.keys(fruits);

let text = "";
for (let x of keys) {
  text += x + "\t";
}
console.log(text)
*/

/*
function munkas(vnev, knev, munkakor, szuletett, fizetes=200000) {
    this.vnev = vnev;
    this.knev = knev;
    this.munkakor = munkakor;
    this.szuletett = szuletett;
    this.fizetes = fizetes;
    this.fullname = vnev + " " + knev;
  }
  const fred = new munkas("Kovács","Fred","Dokkmunkás",1970);
console.log(fred);
console.log(fred.fizetes);
const inas = new munkas("Németh","Józsi","vonatkerék-pumpáló",2020);
console.log(inas)
inas.fizetes=375000;
console.log(inas.fizetes)
*/
/*
let person = {
    firstName : "John",
    lastName  : "Doe",
    age     : 50,
    eyeColor  : "blue"
  };
  console.log(person);
  
  const person = {
    firstName : "John",
    lastName  : "Doe",
    age     : 50,
    eyeColor  : "blue"
  };
  person.firstName="XD";
console.table(person);
console.log(person.firstName + " személy " +person.age +" korú");
*/

// Create a Map
/*
const fruits = new Map([
  ["apples", 500],
  ["bananas", 300],
  ["oranges", 200]
]);
fruits.set("apples", 550);
fruits.set("izéke", 430);
console.log(fruits.get("apples"));  
console.log(fruits.size);
fruits.delete("apples");
console.log(fruits.has("izéke")); //csak kulcsra!!!
//console.table(fruits);
*/

// Create a Map
/*
const fruits = new Map();

// Set Map Values
fruits.set("apples", 500);
fruits.set("bananas", 300);
fruits.set("oranges", 200);
console.log(fruits);
console.log(fruits.size);
fruits.delete("apples");
console.log(fruits.size);
console.log(fruits);
//fruits.clear();
console.log(fruits.has("bananas"));
console.log(typeof fruits);
console.log(fruits instanceof Map);
*/
/*
letters = new Set(["a", "b", "c"]);
console.log(letters);
letters.add("d");
console.log(letters);

let numbers = new Set();

while(numbers.size<10) {
    numbers.add(Math.floor(Math.random()*10+1));
    
}
console.log(numbers);
*/
/*
const szamok = [100,34,45,25];
szamok.sort(); //anomália! szövegként rendez, 1-es van előbb!
//szamok.sort(function(a,b){return a-b});
console.table(szamok);
*/
/*
const numbers2 = [45, 4, 9, 16, 25];
let txt = "";
numbers2.forEach(myFunction);

function myFunction(value) {
  txt += value +"&nbsp;";
}
console.log(txt); //innerHTML-ben pl. a html-kódok is működnek!
*/