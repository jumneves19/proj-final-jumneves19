# Script de Cadastramento de Livros - Contribuição de Thamires
def cadastrar_biblioteca():
    biblioteca = []
    print("\n--- Sistema de Cadastro da Biblioteca ---")

    while True:
        titulo = input("Digite o título do livro (ou 'sair' para encerrar): ")
        if titulo.lower() == 'sair':
            break
        
        autor = input(f"Digite o autor de '{titulo}': ")
        ano = input(f"Digite o ano de publicação: ")
        
        livro = {"titulo": titulo, "autor": autor, "ano": ano}
        biblioteca.append(livro)
        print(f"✅ Livro '{titulo}' cadastrado com sucesso!\n")

    print("\n--- Livros Cadastrados na Unidade ---")
    for i, livro in enumerate(biblioteca, 1):
        print(f"{i}. {livro['titulo']} - Autor: {livro['autor']} ({livro['ano']})")

if __name__ == "__main__":
    cadastrar_biblioteca()
