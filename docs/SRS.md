# MyDietSheet: Especificação de Requisitos de Software (SRS)

**Versão:** v1.0

## Proposta

Um site de dieta feito para o dia a dia das pessoas que treinam ou apenas seguem dieta. O projeto tem como proposta realizar um planejamento de refeições que pode ou não ter sido passado por um profissional como também o usuário pode consultar e planejar a própria dieta. Uma proposta simples que busca facilitar a vida e a dieta de forma descomplicada.

## Funcionalidades

- O site terá cadastro de usuários.
- O usuário poderá planejar suas refeições da dieta, salvá-las e organizar cada dia da semana e cada horário dessas refeições.
- O site disponibilizará uma calculadora automática dos nutrientes de sua dieta.

## Requisitos funcionais

- **RF01:** O usuário preencherá manualmente os campos de cada alimento para planejar uma refeição: nome do alimento, quantidade de kcal e quantidade de macronutrientes em 100g ou, dependendo do alimento, por unidade (opção de unidades escolhida pelo usuário).
- **RF02:** Após o preenchimento manual das informações nutricionais contidas em 100g ou na unidade do alimento, o usuário deve informar a quantidade consumida de cada alimento em cada refeição. Em seguida, o sistema realizará um cálculo automático dos nutrientes totais de cada refeição.
- **RF03:** O sistema exibirá o total de nutrientes de cada dia, atualizado conforme as refeições forem adicionadas ao planejamento.
- **RF04:** Caso o usuário esteja logado, poderá salvar refeições para reutilizá-las no planejador de dieta. Uma refeição é um conjunto de alimentos com quantidades e pode ser associada a qualquer dia e horário.
- **RF05:** O usuário deverá informar e-mail, nome de usuário e senha para se cadastrar com sucesso (e-mail posteriormente será usado para recuperação de conta), sendo obrigatório que e-mail e nome de usuário sejam dados únicos no banco de dados.
- **RF06:** O usuário não utilizará de e-mail para realizar o login, e sim nome de usuário.
- **RF07:** As senhas dos usuários precisam ser salvas com hash e exigência de senha forte, com a senha sendo composta por letras maiúsculas, minúsculas, números, caracteres especiais e tamanho mínimo de 8 caracteres.
- **RF08:** O usuário deve estar cadastrado e logado no site para ter persistência de seus dados.
- **RF09:** O planejamento da dieta e a visualização dos resultados das calculadoras não precisam de autenticação do usuário e são perdidos ao fechar a página.
- **RF10:** O projeto precisa seguir em conformidade a arquitetura RESTful em suas API.
- **RF11:** Os endpoints não podem expor o ID do banco.
- **RF12:** A estrutura HTML deve conter validação de entrada do tipo de dados solicitado como primeira camada de segurança.
- **RF13:** O back-end deve possuir uma camada extra de validação dos dados que entrarem pelo front-end.

## Requisitos não funcionais

- **RNF01:** Para realizar o login é necessário JWT para autenticação do usuário.
- **RNF02:** Utilizar Docker Compose para criação de imagem e evitar problemas de versionamento e facilitar testes e deploy.
- **RNF03:** A funcionalidade de login precisa ter rate limit com o objetivo de aumentar a segurança do software contra ataques de força bruta limitando a 5 tentativas por IP dentro de 1 minuto.
- **RNF04:** As senhas não podem ser armazenadas em texto puro e deve-se utilizar o algoritmo de hash ARGON2ID para armazenar as senhas dos usuários no banco.
- **RNF05:** Senhas devem ser protegidas com PEPPER registrado em um arquivo .env em ambiente local e depois em uma variável de ambiente na plataforma de nuvem escolhida, não pode ser salvo no banco de dados.

## Must have

- Interface inicial com botões intuitivos para as funcionalidades do site.
- Cadastro de usuários para persistência de dados.
- Preenchimento de dados informando alimentos, calorias e macronutrientes em 100g ou unidades.
- Calculadora de calorias e macronutrientes.
- Interface de planejamento de refeições e dos dias e horários que cada refeição será consumida.
- Salvamento de refeições para reutilização.

## Nice to have

- Integração com WhatsApp enviando alarmes dos horários e refeições do dia.
- API para pesquisa de alimentos e informações nutricionais.
- Download de arquivo .txt contendo a dieta.
- Recuperação de conta por e-mail.
- Calculadora de custos da dieta.