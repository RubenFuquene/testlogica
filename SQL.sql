SELECT
    d.department_name AS Nombre_Departamento,
    COUNT(e.id) AS Conteo_Personas,
    SUM(e.salary) AS Salario_Total
FROM
    APPX_department d
JOIN
    APPX_employee e ON d.id = e.department_id
GROUP BY
    d.id, d.department_name
ORDER BY
    Salario_Total ASC;
