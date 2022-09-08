using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Logging;
using HelperBess.WebApiCore.Services;
//using HelperBess.WebApiCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.OpenApi.Models;
using HelperBess.WebApiCore.API;
using Microsoft.AspNetCore.Authentication;

namespace HelperBess.WebApiCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<Models.MailSettings>(Configuration.GetSection("MailSettings"));
            services.AddTransient<IMailService, Services.MailService>();

            services.AddControllers();

            #region -- add cors --
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(origin => true));
            });

            
            #endregion

            #region -- Swagger --
            //Swagger
            
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "HelperBees Service API",
                    Version = "v2",
                    Description = "Service for HelperBees",
                });

                options.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });
            });
                        
            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IUserService, UserService>();
            #endregion

            //error handling logs
            services.AddSingleton<ILog, LogNLog>();
            services.AddSingleton<IConfigurationService, ConfigurationService>();

            services.AddHttpClient();
            services.AddDbContext<Models.HelperBeesContext>(options =>
            options.UseSqlServer(Configuration["DbConnection"]));
            services.AddTransient<IChangeLogService, ChangeLogService>();
            services.AddTransient<IClAccountHolderProfileService, ClAccountHolderProfileService>();
            services.AddTransient<IClAccountHolderService, ClAccountHolderService>();
            services.AddTransient<IClEmergencyContactService, ClEmergencyContactService>();
            services.AddTransient<IClHouseholdDetailService, ClHouseholdDetailService>();
            services.AddTransient<IClInterestService, ClInterestService>();
            services.AddTransient<IClJobServiceService, ClJobServiceService>();
            services.AddTransient<IClloginAuditService, ClloginAuditService>();
            services.AddTransient<IClOtherContactService, ClOtherContactService>();
            services.AddTransient<IClParticipantCulturalBackgroundService, ClParticipantCulturalBackgroundService>();
            services.AddTransient<IClParticipantInterestService, ClParticipantInterestService>();
            services.AddTransient<IClParticipantInterestsOtherService, ClParticipantInterestsOtherService>();
            services.AddTransient<IClParticipantLanguageService, ClParticipantLanguageService>();
            services.AddTransient<IClParticipantMedicationInformationService, ClParticipantMedicationInformationService>();
            services.AddTransient<IClParticipantMedicationService, ClParticipantMedicationService>();
            services.AddTransient<IClParticipantNeedsAreaService, ClParticipantNeedsAreaService>();
            services.AddTransient<IClParticipantNeedService, ClParticipantNeedService>();
            services.AddTransient<IClParticipantReligionService, ClParticipantReligionService>();
            services.AddTransient<IClParticipantService, ClParticipantService>();
            services.AddTransient<IClPaymentDetailService, ClPaymentDetailService>();
            services.AddTransient<IClSocialNeedsGoalService, ClSocialNeedsGoalService>();
            services.AddTransient<ICulturalBackgroundService, CulturalBackgroundService>();
            services.AddTransient<IJobAssignmentService, JobAssignmentService>();
            services.AddTransient<IJobMessageLogService, JobMessageLogService>();
            services.AddTransient<IJobService, JobService>();
            services.AddTransient<IJobTimeService, JobTimeService>();
            services.AddTransient<ILanguageService, LanguageService>();
            services.AddTransient<IReligionService, ReligionService>();
            services.AddTransient<IScimpersonisationLoginAuditService, ScimpersonisationLoginAuditService>();
            services.AddTransient<IScloginAuditService, ScloginAuditService>();
            services.AddTransient<IScSupportCoordinatorProfileService, ScSupportCoordinatorProfileService>();
            services.AddTransient<IScSupportCoordinatorService, ScSupportCoordinatorService>();
            services.AddTransient<IScSupportCoordinatorSupportWorkerService, ScSupportCoordinatorSupportWorkerService>();
            services.AddTransient<IStatusService, StatusService>();
            services.AddTransient<ISwAvailabilityDetailService, SwAvailabilityDetailService>();
            services.AddTransient<ISwAvailabilityService, SwAvailabilityService>();
            services.AddTransient<ISwClientService, SwClientService>();
            services.AddTransient<ISwCoreExperienceFieldService, SwCoreExperienceFieldService>();
            services.AddTransient<ISwCoreExperienceService, SwCoreExperienceService>();
            services.AddTransient<ISwEducationService, SwEducationService>();
            services.AddTransient<ISwEmailPreferenceService, SwEmailPreferenceService>();
            services.AddTransient<ISwEmergencyContactService, SwEmergencyContactService>();
            services.AddTransient<ISwInsuranceDeclarationService, SwInsuranceDeclarationService>();
            services.AddTransient<ISwInvoiceService, SwInvoiceService>();
            services.AddTransient<ISwInvoiceTemplateService, SwInvoiceTemplateService>();
            services.AddTransient<ISwloginAuditService, SwloginAuditService>();
            services.AddTransient<ISwMandatoryCheckService, SwMandatoryCheckService>();
            services.AddTransient<ISwQualificationService, SwQualificationService>();
            services.AddTransient<ISwReferenceService, SwReferenceService>();
            services.AddTransient<ISwServiceGroupService, SwServiceGroupService>();
            services.AddTransient<ISwServiceService, SwServiceService>();
            services.AddTransient<ISwSupportWorkerAdditionalTrainingService, SwSupportWorkerAdditionalTrainingService>();
            services.AddTransient<ISwSupportWorkerAhdetailService, SwSupportWorkerAhdetailService>();
            services.AddTransient<ISwSupportWorkerBankAccountService, SwSupportWorkerBankAccountService>();
            services.AddTransient<ISwSupportWorkerCoreExperienceService, SwSupportWorkerCoreExperienceService>();
            services.AddTransient<ISwSupportWorkerCulturalBackgroundService, SwSupportWorkerCulturalBackgroundService>();
            services.AddTransient<ISwSupportWorkerLanguageService, SwSupportWorkerLanguageService>();
            services.AddTransient<ISwSupportWorkerOtherQualificationService, SwSupportWorkerOtherQualificationService>();
            services.AddTransient<ISwSupportWorkerOtherTrainingService, SwSupportWorkerOtherTrainingService>();
            services.AddTransient<ISwSupportWorkerPcdetailService, SwSupportWorkerPcdetailService>();
            services.AddTransient<ISwSupportWorkerPresignService, SwSupportWorkerPresignService>();
            services.AddTransient<ISwSupportWorkerProfileService, SwSupportWorkerProfileService>();
            services.AddTransient<ISwSupportWorkerQualificationService, SwSupportWorkerQualificationService>();
            services.AddTransient<ISwSupportWorkerReligionService, SwSupportWorkerReligionService>();
            services.AddTransient<ISwSupportWorkerRndetailService, SwSupportWorkerRndetailService>();
            services.AddTransient<ISwSupportWorkerService, SwSupportWorkerService>();
            services.AddTransient<ISwSupportWorkerServiceService, SwSupportWorkerServiceService>();
            services.AddTransient<ISwTimesheetIncidentService, SwTimesheetIncidentService>();
            services.AddTransient<ISwTimesheetService, SwTimesheetService>();
            services.AddTransient<ISwTimesheetStatusService, SwTimesheetStatusService>();
            services.AddTransient<ISwTransportInfoService, SwTransportInfoService>();
            services.AddTransient<ISwWorkHistoryService, SwWorkHistoryService>();
            services.AddTransient<ISW_SupportWorkerUploadFiles, SW_SupportWorkerUploadFilesService>();
            services.AddTransient<ICLEmailPreferenceService, ClEmailPreferenceService>();
            services.AddTransient<IAdministratorService, AdministratorService>();
            services.AddTransient<IAdministratorProfileService, AdministratorProfileService>();
            services.AddTransient<IAdminSupportWorkerService, AdminSupportWorkerService>();
            services.AddTransient<IAdminAccountHolderService, AdminAccountHolderService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILog logger)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.UseHttpsRedirection();

            //app.UseRouting();

            ////app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});


            //Swagger
            //if (env.IsDevelopment()) { app.UseDeveloperExceptionPage();

            app.UseDeveloperExceptionPage();           

            //error handling logs
            app.ConfigureExceptionHandler(logger);

            #region -- Swagger --
            app.UseSwagger();
            app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v2/swagger.json", "HelperBees Services"));
            #endregion

            app.UseHttpsRedirection();
            app.UseRouting();

            #region -- add cors --
            
            app.UseCors("AllowOrigin");

            #endregion

            app.UseAuthentication();

            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            //app.UseEndpoints(endpoints => { endpoints.MapControllers().RequireCors("AllowOrigin"); });

        }
    }
}
