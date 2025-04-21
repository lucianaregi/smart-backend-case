# Questão 6 – SQL: Geração de Kits 🧼🥫

Essa query monta combinações entre produtos de limpeza bem avaliados e alimentos que estão prestes a vencer, com o objetivo de gerar kits promocionais.

---

## 🧠 Lógica utilizada

- Produtos de limpeza precisam ter **satisfação média acima de 70**
- Alimentos precisam ter **validade inferior a 5 dias a partir da data atual**
- O preço final do kit tem **15% de desconto aplicado**
- O lucro é calculado com base no **custo total do alimento + produto de limpeza**
- A data de validade do kit é a do alimento (por ser o componente mais perecível)

---

## 📊 O que foi usado

- `CTE` (Common Table Expressions) para organizar as partes da lógica
- `JOIN` para relacionar tabelas de estoque, mercado e produtos
- `CROSS JOIN` para combinar todos os produtos de limpeza com todos os alimentos (sem filtro de estoque)
- `ORDER BY` para listar os kits mais lucrativos primeiro

---

## 📁 Local do script

O script completo está neste arquivo:

📄 `codigo/Questao6_SQL/script.sql`

Tu podes executá-lo num ambiente SQL Server compatível com CTEs e funções de data.

---
