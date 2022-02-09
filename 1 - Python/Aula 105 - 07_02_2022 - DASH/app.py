from dash import Dash, html, dcc
import plotly.express as px
import pandas as pd

app = Dash(__name__)

df = pd.DataFrame({
    'Frutas': ['Maçãs', 'Laranjas', 'Bananas', 'Maçãs', 'Laranjas', 'Bananas', 'Maçãs'],
    'Quantidade': [4, 1, 2, 2, 4, 5, 1],
    'Estado': ['SP', 'SP', 'SP', 'Paraná', 'Paraná', 'Paraná', 'Santa Catarina']
})

fig = px.bar(df, x='Frutas', y='Quantidade', color='Estado', barmode='group')

app.layout = html.Div(children=[
    html.H1(children='Olá Dash'),

    html.Div(children='Dash: Uma estrutura de trabalho para aplicação web para os seus dados.'),

    dcc.Graph(
        id='example-graph',
        figure=fig
    )
])

if __name__ == '__main__':
    app.run_server(debug=False)
