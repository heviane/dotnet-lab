# XAML (eXtensible Application Markup Language)

É uma linguagem de marcação declarativa baseada em XML.
Linguagem de Marcação Específicas do .NET.

Em vez de escrever código em C# para criar, configurar e posicionar cada botão, campo de texto ou imagem na tela (o que seria um processo imperativo), com XAML você simplesmente declara a estrutura da sua interface de usuário (UI).

**Pense nisso como o HTML para aplicações .NET:**

- O quê? É uma linguagem para definir a aparência e a estrutura da interface de um programa.
- Por quê? Seu principal objetivo é separar a definição da interface (o "o quê", em XAML) da lógica de negócio (o "como", em C#). Isso torna o código mais limpo, organizado e fácil de manter.
- Onde é usado? É a tecnologia principal para construir a interface de usuário em frameworks .NET como:
  - **.NET MAUI**: Para criar aplicações mobile (iOS/Android) e desktop (Windows/macOS) nativas.
  - **WPF (Windows Presentation Foundation)**: Para criar aplicações desktop ricas para Windows.

**Exemplo Prático**
Veja como um simples formulário de login seria declarado em XAML para uma aplicação .NET MAUI:

```xml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MyApp.LoginPage">

    <!-- Um layout que empilha os elementos verticalmente -->
    <VerticalStackLayout Spacing="15" Padding="20">

        <Label Text="Bem-vindo!"
               FontSize="Large"
               HorizontalOptions="Center" />

        <Entry x:Name="EmailEntry"
               Placeholder="Digite seu e-mail" />

        <Entry x:Name="PasswordEntry"
               Placeholder="Digite sua senha"
               IsPassword="True" />

        <Button Text="Entrar"
                Clicked="OnLoginButtonClicked" />

    </VerticalStackLayout>

</ContentPage>
```

Neste exemplo:

- As "tags" como `<Label>`, `<Entry>` e `<Button>` representam os controles visuais.
- Os "atributos" como `Text`, `Placeholder`, `IsPassword` e `Clicked`, e `FontSize` definem as propriedades desses controles.
- A lógica, como o que acontece quando o botão é clicado (OnLoginButtonClicked), é tratada em um arquivo C# separado, associado a este XAML.

Em resumo, se você pretende criar aplicações desktop ou mobile com interface gráfica nativa no ecossistema .NET, aprender XAML é um passo essencial.
