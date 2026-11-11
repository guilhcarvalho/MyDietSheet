# MyDietSheet: Especificação de Requisitos de Software (SRS)

**Versão:** v1.0

## Proposta

Um site de dieta feito para o dia a dia das pessoas que treinam ou apenas seguem dieta. O projeto tem como proposta realizar um planejamento de refeições que pode ou não ter sido passado por um profissional como também o usuário pode consultar e planejar a própria dieta. Uma proposta simples que busca facilitar a vida e a dieta de forma descomplicada.

## Funcionalidades

- O site terá cadastro de usuários.
- O usuário poderá planejar suas refeições da dieta, salvá-las e organizar cada dia da semana e cada horário dessas refeições.
- O site disponibilizará uma calculadora automática dos nutrientes de sua dieta.

## Requisitos funcionais

- **RF01:** O sistema terá como base de dados as informações da tabela TACO (Tabela Brasileira de Composição de Alimentos) na 4ª edição (2011).
- **RF02:** Os dados da tabela TACO precisam estar disponíveis ao usuário para o planejamento das refeições, e os alimentos poderão ser pesquisados pelo nome.
- **RF03:** O usuário deve informar a quantidade consumida, em gramas, de cada alimento em cada refeição que planejar. Como os valores nutricionais da TACO são expressos por 100 g de alimento, o sistema calculará automaticamente cada nutriente proporcionalmente à quantidade informada (valor por 100 g × quantidade em gramas ÷ 100) e somará os resultados para obter os nutrientes totais de cada refeição.
- **RF04:** O sistema exibirá o total de nutrientes de cada dia, atualizado conforme as refeições forem adicionadas ao planejamento.
- **RF05:** Caso o usuário esteja logado, poderá salvar refeições para reutilizá-las no planejador de dieta. Uma refeição é um conjunto de alimentos com quantidades e pode ser associada a qualquer dia e horário.
- **RF06:** O usuário deverá informar e-mail, nome de usuário e senha para se cadastrar com sucesso (e-mail posteriormente será usado para recuperação de conta), sendo obrigatório que e-mail e nome de usuário sejam dados únicos no banco de dados.
- **RF07:** O usuário não utilizará de e-mail para realizar o login, e sim nome de usuário.
- **RF08:** As senhas dos usuários precisam ser salvas com hash e exigência de senha forte, com a senha sendo composta por letras maiúsculas, minúsculas, números, caracteres especiais e tamanho mínimo de 8 caracteres.
- **RF09:** O usuário deve estar cadastrado e logado no site para ter persistência de seus dados.
- **RF10:** O planejamento da dieta e a visualização dos resultados das calculadoras não precisam de autenticação do usuário e são perdidos ao fechar a página.
- **RF11:** O projeto precisa seguir em conformidade a arquitetura RESTful em suas API.
- **RF12:** Os endpoints não podem expor o ID utilizado como primary key da tabela de users do banco, e sim utilizar uuid como id público.
- **RF13:** A estrutura HTML deve conter validação de entrada do tipo de dados solicitado como primeira camada de segurança.
- **RF14:** O back-end deve possuir uma camada extra de validação dos dados que entrarem pelo front-end.
- **RF15:** Os nutrientes serão preenchidos automaticamente ao selecionar o alimento e serão tratados apenas calorias e macronutrientes principais.
- **RF16:** O site disponibilizará uma página para consulta e navegação dos alimentos da tabela TACO.
- **RF17:** Um usuário só poderá visualizar, alterar e excluir as refeições salvas e o planejamento que lhe pertencem. Tentativas de acessar dados de outro usuário devem ser negadas.

## Requisitos não funcionais

- **RNF01:** Para realizar o login é necessário JWT para autenticação do usuário.
- **RNF02:** Utilizar Docker Compose para criação de imagem e evitar problemas de versionamento e facilitar testes e deploy.
- **RNF03:** A funcionalidade de login precisa ter rate limit com o objetivo de aumentar a segurança do software contra ataques de força bruta limitando a 5 tentativas por IP dentro de 1 minuto.
- **RNF04:** As senhas não podem ser armazenadas em texto puro e deve-se utilizar o algoritmo de hash ARGON2ID para armazenar as senhas dos usuários no banco.
- **RNF05:** Senhas devem ser protegidas com PEPPER registrado em um arquivo .env em ambiente local e depois em uma variável de ambiente na plataforma de nuvem escolhida, não pode ser salvo no banco de dados.

## Must have

- Interface inicial com botões intuitivos para as funcionalidades do site.
- Cadastro de usuários para persistência de dados.
- Consulta e busca de alimentos da TACO.
- Calculadora de calorias e macronutrientes.
- Interface de planejamento de refeições e dos dias e horários que cada refeição será consumida.
- Salvamento de refeições para reutilização.

## Nice to have

- Integração com WhatsApp enviando alarmes dos horários e refeições do dia.
- Download de arquivo .txt contendo a dieta.
- Recuperação de conta por e-mail.
- Calculadora de custos da dieta.
