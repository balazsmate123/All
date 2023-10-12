2.feladat
SELECT nev, terulet
FROM alloviz
WHERE tipus like "*morotva*"
ORDER BY terulet DESC;

3.feladat
SELECT SELECT Sum(terulet)/93036 AS "lefedett terület"
FROM alloviz;

4.feladat
SELECT nev, tipus, terulet
FROM alloviz
WHERE terulet Between 3 and 10
and vizgyujto>=10*terulet;

 5.feladat
SELECT nev, Count(gpsid) AS Darab
FROM alloviz
INNER JOIN helykapcs ON alloviz.id = helykapcs.allovizid 
GROUP BY id, nev
HAVING Count(gpsid)>=3;

6.feladat
SELECT alloviz.nev
FROM helykapcs
INNER JOIN alloviz ON helykapcs.allovizid = alloviz.id
INNER JOIN telepulesgps ON helykapcs.gpsid = telepulesgps.id
GROUP BY allovizid, alloviz.nev
ORDER BY max(hosszusag)-min(hosszusag) DESC 
LIMIT 1;
