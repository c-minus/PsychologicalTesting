using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PsychologicalTesting;
using PsychologicalTesting.Services.ClipboardServiceNS;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.DataSeed;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Adhd;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.AdhdConners3;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.Disorder;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Indexes.PiAndNi;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Profiles;
using PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.Result;
using Services.ConnersSelfEvaluationServiceNS;
using Services.ConnersSelfEvaluationServiceNS.Data;
using Services.ConnersSelfEvaluationServiceNS.DataSeed;
using Services.ConnersSelfEvaluationServiceNS.Indexes;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IDataSeed, FileDataSeed>();
builder.Services.AddSingleton<IConnersSelfEvaluationService, ConnersSelfEvaluationService>();
builder.Services.AddSingleton<ICategoryTypeFactory, CategoryTypeFactory>();
builder.Services.AddSingleton<IScoringTypeFactory, ScoringTypeFactory>();
builder.Services.AddSingleton<IinconsistencyIndexCalculator, InconsistencyIndexCalculator>();
builder.Services.AddSingleton<IPiAndNiIndexCalculator, PiAndNiIndexCalculator>();
builder.Services.AddSingleton<IClipboardService, ClipboardService>();
builder.Services.AddSingleton<IAdhdHyperActiveIndex, AdhdHyperActiveCalculator>();
builder.Services.AddSingleton<IAdhdInattentiveIndex, AdhdInattentiveCalculator>();
builder.Services.AddSingleton<IBehaviorDisorderIndex, BehaviorDisorderIndex>();
builder.Services.AddSingleton<IOppositionDisorderIndex, OppositionDisorderIndex>();
builder.Services.AddSingleton<IAdhdConners3Calculator, AdhdConners3Calculator>();
builder.Services.AddSingleton<IProfileFactory, ProfileFactory>();
builder.Services.AddSingleton<IResultCalculator, ResultCalculator>();

await builder.Build().RunAsync();

