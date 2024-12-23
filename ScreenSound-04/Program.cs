﻿using System.Text.Json;
using ScreenSound_04.Exercicio.CriandoArquivoComCSharp.Exercicio4;
using ScreenSound_04.Exercicio.CriandoArquivoComCSharp.Exercicio5;
using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;

public class Program
{
    
    //https://hp-api.onrender.com/api/characters/house/gryffindor

    public static async Task Main(string[] args)
    {
        //IntegrandoUmaAPIExterna
        //await new Exercicio1().Executar();
        //await new Exercicio2().Executar();
        //await new Exercicio3().Executar();
        //await new Exercicio4().Executar();
        
        //LinqEOrdenacao
        //Exercicio1.Exercicio();
        //await Exercicio2.Exercicio();
        //Exercicio3.Exercicio();
        //Exercicio4.Exercicio();
        
        //CriandoCaminhoComCSharp
        //Exercicio1.Executar();
        //Exercicio2.Executar();
        //new Exercicio3().Executar();
        //Exercicio4.Executar();
        //new Exercicio5().Executar();

        await APIMusicas();

    }

    static async Task APIMusicas()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string response = await client
                    .GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
                
                //Deserialização da API de Musicas em uma Classe 
                var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;

                //musicas[0].ExibeInformacoesMusica();

                //ExibirTodasMusicas(musicas);

                //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
                //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
                //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "Dance/Electronic");
                //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Chris Brown");
                //LinqFilter.FiltrarTodasAsMusicasPorAno(musicas, "2010");
                //LinqFilter.FiltrarMusicasDeUmArtistaComIndice(musicas, "Arctic Monkeys");
                //LinqFilter.FiltrarMusicasEmCSharp(musicas);

                var musicasFavoritasKelvin = new MusicasFavoritas("Kelvin");

                musicasFavoritasKelvin.AdicionarMusicasFavoritas(musicas[365]);
                musicasFavoritasKelvin.AdicionarMusicasFavoritas(musicas[1623]);
                musicasFavoritasKelvin.AdicionarMusicasFavoritas(musicas[410]);
                musicasFavoritasKelvin.AdicionarMusicasFavoritas(musicas[1884]);
                musicasFavoritasKelvin.AdicionarMusicasFavoritas(musicas[1909]);

                //musicasFavoritasKelvin.ExibirMusicasFavoritas();

                //musicas[400].ExibeInformacoesMusica();

                //musicasFavoritasKelvin.GerarArquivoJson();
                //musicasFavoritasKelvin.GerarArquivoJsonComStream();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }
        }
    }

    static void ExibirTodasMusicas(List<Musica> musicas)
    {
        int index = 0;
        musicas.ForEach(musica => 
            {
                Console.WriteLine($"{index} -> {musica.Nome}");
                index++;
            });        
    }
}
