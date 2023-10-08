using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PsychologicalTesting;
using PsychologicalTesting.Services;
using PsychologicalTesting.Services.ClipboardServiceNS;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Disorder;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi;
using Services.ConnersSelfEvaluationServiceNS;
using Services.ConnersSelfEvaluationServiceNS.Data;
using Services.ConnersSelfEvaluationServiceNS.DataSeed;
using Services.ConnersSelfEvaluationServiceNS.Indexes;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IDataSeed, TestDataSeed>();
builder.Services.AddSingleton<IConnersSelfEvaluationService, ConnersSelfEvaluationService>();
builder.Services.AddSingleton<ICategoryTypeFactory, CategoryTypeFactory>();
builder.Services.AddSingleton<IScoringTypeFactory, ScoringTypeFactory>();
builder.Services.AddSingleton<IinconsistencyIndexCalculator, InconsistencyIndexCalculator>();
builder.Services.AddSingleton<IPiAndNiIndexCalculator, PiAndNiIndexCalculator>();
builder.Services.AddSingleton<IClipboardService, ClipboardService>();
builder.Services.AddSingleton<IAdhdHyperActiveIndex, AdhdHyperActiveIndex>();
builder.Services.AddSingleton<IAdhdInattentiveIndex, AdhdInattentiveIndex>();
builder.Services.AddSingleton<IBehaviorDisorderIndex, BehaviorDisorderIndex>();
builder.Services.AddSingleton<IOppositionDisorderIndex, OppositionDisorderIndex>();
builder.Services.AddSingleton<IAdhdConners3Calculator, AdhdConners3Calculator>();

await builder.Build().RunAsync();

