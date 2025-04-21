-- Define a data de hoje para referência de validade
DECLARE @Hoje DATETIME = GETDATE();

-- CTE para calcular a satisfação média por produto de limpeza
WITH SatisfacaoMediaLimpeza AS (
    SELECT
        pl.id AS id_produto_limpeza,
        pl.nome AS nome_produto_limpeza,
        AVG(CAST(pm.satisfacao AS DECIMAL(5, 2))) AS satisfacao_media,
        ee_pl.custo AS custo_produto_limpeza,
        ee_pl.preco AS preco_produto_limpeza
    FROM Produto_Limpeza pl
    JOIN Pesquisa_Mercado pm ON pl.id = pm.id_produto_limpeza
    JOIN Elemento_Estoque ee_pl ON pl.id_elemento_estoque = ee_pl.id
    GROUP BY
        pl.id,
        pl.nome,
        ee_pl.custo,
        ee_pl.preco
    HAVING
        AVG(CAST(pm.satisfacao AS DECIMAL(5, 2))) > 70.0
),
AlimentosPertoVencer AS (
    SELECT
        a.id AS id_alimento,
        a.nome AS nome_alimento,
        a.data_validade,
        ee_a.custo AS custo_alimento,
        ee_a.preco AS preco_alimento
    FROM Alimento a
    JOIN Elemento_Estoque ee_a ON a.id_elemento_estoque = ee_a.id
    WHERE
        DATEDIFF(day, @Hoje, a.data_validade) < 5
        AND a.data_validade >= @Hoje
)
SELECT
    sml.nome_produto_limpeza,
    apv.nome_alimento,
    CAST((sml.preco_produto_limpeza + apv.preco_alimento) * 0.85 AS DECIMAL(10, 2)) AS preco_kit,
    CAST(((sml.preco_produto_limpeza + apv.preco_alimento) * 0.85) - (sml.custo_produto_limpeza + apv.custo_alimento) AS DECIMAL(10, 2)) AS lucro_kit,
    apv.data_validade AS data_validade_kit
FROM
    SatisfacaoMediaLimpeza sml
CROSS JOIN
    AlimentosPertoVencer apv
ORDER BY
    lucro_kit DESC;
