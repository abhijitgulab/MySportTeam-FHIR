using System;
using System.ComponentModel.DataAnnotations;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
namespace MySportTeam.Models
{

  public class Patient_FHIR
       {
        public int Id { get; set; }
        public string Family { get; set; }
         public string Given { get; set; }

        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }
        public string Gender { get; set; }

        public string Identifier { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        //From this point below, we are getting this info from the FHIR Server
        public string FHIRServerAddress{ get; set; }
        //Demographic Information
        public Hl7.Fhir.Model.Patient FHIR_Demographics { get; set; }
        public string FullAddress { get; set; }
       //This is the solution to Section A
        public string FullTelecom { get; set; }
        public string City { get; set; }
        public string Race { get; set; }
        //This is the solution to Section B
        public string Ethnicity { get; set; }
        
        //Conditions
        public System.Collections.Generic.List<Hl7.Fhir.Model.Condition> Conditions{ get; set; }
        //Allergies
        public System.Collections.Generic.List<Hl7.Fhir.Model.AllergyIntolerance> Allergies{ get; set; }
        //Medications
        public System.Collections.Generic.List<Hl7.Fhir.Model.MedicationRequest> Medications{ get; set; }
        //This is the solution  to Section C
        //Immunization
        public System.Collections.Generic.List<Hl7.Fhir.Model.Immunization> Immunizations{ get; set; }
        public System.Collections.Generic.List<Hl7.Fhir.Model.Practitioner> PractitionersNear{ get; set; }
       }
       

       public class Patient_FHIR_Helper
       {
           public string FHIR_EndPoint_PatientInfo =  "http://fhir.hl7fundamentals.org/r4";  

           public bool GetInfo(Patient_FHIR pf)
           {
                pf.FHIR_Demographics=FHIR_SearchByIdentifier(pf.Identifier);
                bool found=false;
                if (pf.FHIR_Demographics!=null)
                {
                    pf.FullAddress=GetAddress(pf.FHIR_Demographics);
                    pf.FullTelecom=GetTelecom(pf.FHIR_Demographics);
                    pf.Conditions=FHIR_SearchConditions(pf.FHIR_Demographics.Id);
                    pf.Medications=FHIR_SearchMedications(pf.FHIR_Demographics.Id);
                    pf.Allergies=FHIR_SearchAllergies(pf.FHIR_Demographics.Id);
                    pf.Immunizations=FHIR_SearchImmunizations(pf.FHIR_Demographics.Id);
                    pf.City=GetCity(pf.FHIR_Demographics);
                    pf.Race=GetRace(pf.FHIR_Demographics);
                    pf.FHIRServerAddress=FHIR_EndPoint_PatientInfo;
                    if (pf.FHIR_Demographics.Address.Count>0)
                    {pf.PractitionersNear=FHIR_SearchPractitioners(pf.FHIR_Demographics.Address[0].City);};
                    found=true;
                }
                return found;
                
        }
       public Hl7.Fhir.Model.Patient FHIR_SearchByIdentifier(string Identifier)
        {
             Hl7.Fhir.Model.Patient  o=new  Hl7.Fhir.Model.Patient() ;
            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint_PatientInfo); 
            client.PreferredFormat=ResourceFormat.Json;
            Bundle bu = client.Search <Hl7.Fhir.Model.Patient> (new string[]
             {"identifier="  +Identifier});  
            if (bu.Entry.Count>0)
                    {
                        o=(Hl7.Fhir.Model.Patient)bu.Entry[0].Resource;
                    }
            return o;
        }
        public System.Collections.Generic.List<Hl7.Fhir.Model.Condition> FHIR_SearchConditions(string PatientId)
        {
            
            System.Collections.Generic.List<Hl7.Fhir.Model.Condition> Cs=new System.Collections.Generic.List<Hl7.Fhir.Model.Condition>();
            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint_PatientInfo); 
            client.PreferredFormat=ResourceFormat.Json;
            Bundle bu = client.Search <Hl7.Fhir.Model.Condition> (new string[]
             {"patient="  +PatientId});  
            foreach(Bundle.EntryComponent ent in bu.Entry) {  
                Condition c = (Condition) ent.Resource;  
                Cs.Add(c);
            }
            return Cs;

        }
        
        public System.Collections.Generic.List<Hl7.Fhir.Model.AllergyIntolerance> FHIR_SearchAllergies(string PatientId)
        {
            
            System.Collections.Generic.List<Hl7.Fhir.Model.AllergyIntolerance> As=new System.Collections.Generic.List<Hl7.Fhir.Model.AllergyIntolerance>();
            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint_PatientInfo); 
            client.PreferredFormat=ResourceFormat.Json;
            Bundle bu = client.Search <Hl7.Fhir.Model.AllergyIntolerance> (new string[]
             {"patient="  +PatientId});  
            foreach(Bundle.EntryComponent ent in bu.Entry) {  
                AllergyIntolerance a = (AllergyIntolerance) ent.Resource;  
                As.Add(a);
            }
            return As;

        }
            public System.Collections.Generic.List<Hl7.Fhir.Model.Practitioner> FHIR_SearchPractitioners(string city)
        {
            
            System.Collections.Generic.List<Hl7.Fhir.Model.Practitioner> Prs=new System.Collections.Generic.List<Hl7.Fhir.Model.Practitioner>();
            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint_PatientInfo); 
            client.PreferredFormat=ResourceFormat.Json;
            Bundle bu = client.Search <Hl7.Fhir.Model.Practitioner> (new string[]
             {"address-city="  +city});  
            foreach(Bundle.EntryComponent ent in bu.Entry) {  
                Practitioner pra = (Practitioner) ent.Resource;  
                Prs.Add(pra);
            }
            return Prs;

        }
    
        public System.Collections.Generic.List<Hl7.Fhir.Model.MedicationRequest> FHIR_SearchMedications(string PatientId)
        {
            
            System.Collections.Generic.List<Hl7.Fhir.Model.MedicationRequest> Ms=new System.Collections.Generic.List<Hl7.Fhir.Model.MedicationRequest>();
            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint_PatientInfo); 
            client.PreferredFormat=ResourceFormat.Json;
            Bundle bu = client.Search <Hl7.Fhir.Model.MedicationRequest> (new string[]
             {"patient="  +PatientId});  
            foreach(Bundle.EntryComponent ent in bu.Entry) {  
                MedicationRequest m = (MedicationRequest) ent.Resource;  
                Ms.Add(m);
            }
            return Ms;

        }
          public System.Collections.Generic.List<Hl7.Fhir.Model.Immunization> FHIR_SearchImmunizations(string PatientId)
        {
            
            System.Collections.Generic.List<Hl7.Fhir.Model.Immunization> Ms=new System.Collections.Generic.List<Hl7.Fhir.Model.Immunization>();
            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint_PatientInfo); 
            client.PreferredFormat=ResourceFormat.Json;
            Bundle bu = client.Search <Hl7.Fhir.Model.Immunization> (new string[]
             {"patient="  +PatientId});  
            foreach(Bundle.EntryComponent ent in bu.Entry) {  
                Immunization m = (Immunization) ent.Resource;  
                Ms.Add(m);
            }
            return Ms;

        }
        public string GetRace(Hl7.Fhir.Model.Patient p)
        {
                
                string ExtList = "";
                Extension ComplexEx = p.GetExtension("http://hl7.org/fhir/us/core-r4/StructureDefinition/us-core-race");
                if (ComplexEx != null)
                {
                    foreach (Extension SimpleEx in ComplexEx.Extension)
                    {

                        string ExtURL = SimpleEx.Url;
                        string ExtType = "null";
                        string MyValue = "";

                        if (SimpleEx.Value != null)
                        {
                            ExtType = SimpleEx.Value.TypeName;
                            if (ExtType == "Coding")
                            {
                                Coding c = (Coding)SimpleEx.Value;
                                string MyCode = c.Code;
                                string MyDisplay=c.Display;
                                MyValue = MyCode + ":" + MyDisplay;
                                ;
                                ExtList = ExtList +  MyValue+" - ";
                            }
                        }

                    }
                }
             
                return ExtList;

        }
        public string GetCity(Hl7.Fhir.Model.Patient p)
        {
                
                string ci="";
                if (p.Address.Count>0)
                {
                    ci=p.Address[0].City;
                }
                return ci;

        }
        
        public string GetAddress(Hl7.Fhir.Model.Patient p)
        {
                string ad="";
                foreach(Address a in p.Address)
                    {
                        ad=ad+a.LineElement[0].ToString()+ " "+a.City+" "+a.State+" "+a.Country+ "( "+a.PostalCode+") / ";
                    }
                return ad;

        }
         //This is the solution to Section A
      public string GetTelecom(Hl7.Fhir.Model.Patient p)
        {
                string te="";
                foreach( ContactPoint c in p.Telecom)
                    {
                        te=te+c.System+":"+c.Value+" / ";
                    }
                return te;

        }
        
       }
}
