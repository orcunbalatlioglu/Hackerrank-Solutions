SELECT TOP 1 CITY, LEN(CITY) FROM STATION GROUP BY CITY ORDER BY LEN(CITY),CITY;
SELECT TOP 1 CITY, LEN(CITY) FROM STATION GROUP BY CITY ORDER BY LEN(CITY) DESC, CITY;