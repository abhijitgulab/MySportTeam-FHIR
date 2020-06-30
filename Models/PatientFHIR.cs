using System;
using System.ComponentModel.DataAnnotations;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Collections.Generic;
using static Hl7.Fhir.Model.ContactPoint;
using System.Linq;

namespace MySportTeam.Models
{

    public class PractitionersNear
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public string Telecom { get; set; }

        public string Specialty { get; set; }

    }

  public class Patient_FHIR
       {
        public int Id { get; set; }
        public string Family { get; set; }
         public string Given { get; set; }

        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }
        public string Gender { get; set; }

        public bool bFamilyMatch {get;set;}
        public string FHIR_Family { get; set; }
         public string FHIR_Given { get; set; }

        [DataType(DataType.Date)]
        public DateTime FHIR_birthDate { get; set; }
        public string FHIR_Gender { get; set; }

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

        public string FullEmail { get; set; }
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
        public List<PractitionersNear> PractitionersNear{ get; set; }
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
                    
                    pf.FHIR_Family = GetFhirFamily(pf.FHIR_Demographics, pf.Family);
                    pf.FHIR_Given = GetFhirGiven(pf.FHIR_Demographics, pf.Given);
                    pf.FHIR_birthDate = GetFhirDateOfBirth(pf.FHIR_Demographics);
                    pf.FHIR_Gender = pf.FHIR_Demographics.Gender.ToString();
                    pf.FullAddress=GetAddress(pf.FHIR_Demographics);
                    pf.FullTelecom=GetTelecom(pf.FHIR_Demographics);
                    pf.FullEmail=GetEmail(pf.FHIR_Demographics);
                    pf.Conditions=FHIR_SearchConditions(pf.FHIR_Demographics.Id);
                    pf.Medications=FHIR_SearchMedications(pf.FHIR_Demographics.Id);
                    pf.Allergies=FHIR_SearchAllergies(pf.FHIR_Demographics.Id);
                    pf.Immunizations=FHIR_SearchImmunizations(pf.FHIR_Demographics.Id);
                    pf.City=GetCity(pf.FHIR_Demographics);
                    pf.Race=GetRace(pf.FHIR_Demographics);
                    pf.Ethnicity=GetEthnicity(pf.FHIR_Demographics);
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
            public List<PractitionersNear> FHIR_SearchPractitioners(string city)
        {
            
            IList<Practitioner> practitioners = new List<Practitioner>();
            IList<PractitionerRole> practitionerRoles = new List<PractitionerRole>();
            IList<Organization> organizations = new List<Organization>();
            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint_PatientInfo); 
            client.PreferredFormat=ResourceFormat.Json;
            try
            {
                //Search for Practitioner in Patient's city and Reverse include all PractitionerRoles Practitioners have.
                Bundle bu3 = client.Search<Practitioner>(new string[] { "address-city="+ city, "_revinclude=PractitionerRole:practitioner", "_include=PractitionerRole:organization" });

                foreach (Bundle.EntryComponent entry in bu3.Entry)
                {
                    string fullUrl = entry.FullUrl;
                    string ResourceType = entry.Resource.TypeName;
                    if (ResourceType == "Practitioner")
                    {
                        Practitioner practitioner = (Practitioner)entry.Resource;
                        practitioners.Add(practitioner);
                    }
                    else if (ResourceType == "PractitionerRole")
                    {
                        PractitionerRole practitionerRole = (PractitionerRole)entry.Resource;
                        practitionerRoles.Add(practitionerRole);
                    }
                    else if (ResourceType == "Organization")
                    {
                        Organization organization = (Organization)entry.Resource;
                        organizations.Add(organization);
                    }

                }

                // Linq 
                /*var practitionersNear = from practitioner in practitioners
                join practitionerRole in practitionerRoles on "Practitioner/"+practitioner.Id equals practitionerRole.Practitioner.Url.ToString()
                join organization in organizations on practitionerRole.Organization.Url.ToString() equals "Organization/" + organization.Id


                select new  PractitionersNear
                {
                    Name = practitioner.Name.FirstOrDefault().Family + "," + practitioner.Name.FirstOrDefault().Given.FirstOrDefault(),
                    
                    Telecom =  string.Join(Environment.NewLine, organization.Telecom.Select(t => t.Value + " (" + t.Use + ")")),
                    Address = string.Join(Environment.NewLine, organization.Address.FirstOrDefault().Line) +  " " +
                              organization.Address.FirstOrDefault().City + " "+
                              organization.Address.FirstOrDefault().PostalCode + " " +
                              organization.Address.FirstOrDefault().State,
                    Specialty = string.Join(Environment.NewLine, practitionerRole.Specialty.Select(s => s.Text))

                };*/

                //Switching to looping

                // 1. First fill in the details from Practitioner resource.
                // 2. Then check if the Practitioner is part of PractitionerRole
                // 3. Fetch the Address details from PractitionerRole.Organization and fill the Specialty

                List<PractitionersNear> practitionersNear = new List<PractitionersNear>();

                foreach(var practitioner in practitioners)
                {
                    var newPractitionerNear = new PractitionersNear()
                    {
                        Name = practitioner.Name.FirstOrDefault().Family + "," + practitioner.Name.FirstOrDefault().Given.FirstOrDefault(),
                        Telecom = string.Join(Environment.NewLine, practitioner.Telecom.Select(t => t.Value + " (" + t.Use + ")")),
                        Address = string.Join(Environment.NewLine, practitioner.Address.FirstOrDefault().Line) +  " " +
                              practitioner.Address.FirstOrDefault().City + " "+
                              practitioner.Address.FirstOrDefault().PostalCode + " " +
                              practitioner.Address.FirstOrDefault().State,
                        Specialty = "Not Available"
                    };
                    bool foundPractitionerRole = false;
                    foreach(var practitionerRole in practitionerRoles)
                    {
                        var practitionerRef = "Practitioner/" + practitioner.Id;
                        if(practitionerRef.Equals(practitionerRole.Practitioner.Url.ToString()))
                        {
                          if(!foundPractitionerRole)
                          {
                             foundPractitionerRole = true;
                             //Check for specialty
                              newPractitionerNear.Specialty = string.Join(Environment.NewLine, practitionerRole.Specialty.Select(s => s.Text));
                              foreach(var organization in organizations)   
                              {
                                   var organizationRef = "Organization/" + organization.Id;
                                  if(organizationRef.Equals(practitionerRole.Organization.Url.ToString()))
                                  {
                                      newPractitionerNear.Telecom =  string.Join(Environment.NewLine, organization.Telecom.Select(t => t.Value + " (" + t.Use + ")"));
                                      newPractitionerNear.Address = organization.Name + " " +
                                                string.Join(Environment.NewLine, organization.Address.FirstOrDefault().Line) +  " " +
                                                organization.Address.FirstOrDefault().City + " "+
                                                organization.Address.FirstOrDefault().PostalCode + " " +
                                                organization.Address.FirstOrDefault().State;

                                    break;

                                  }
                                  


                              }
                              practitionersNear.Add(newPractitionerNear);
                          }
                          else
                          {
                              var newPractitionerNearInLoop = new PractitionersNear()
                                {
                                    Name = practitioner.Name.FirstOrDefault().Family + "," + practitioner.Name.FirstOrDefault().Given.FirstOrDefault(),
                                    Telecom = string.Join(Environment.NewLine, practitioner.Telecom.Select(t => t.Value + " (" + t.Use + ")")),
                                    Address = string.Join(Environment.NewLine, practitioner.Address.FirstOrDefault().Line) +  " " +
                                        practitioner.Address.FirstOrDefault().City + " "+
                                        practitioner.Address.FirstOrDefault().PostalCode + " " +
                                        practitioner.Address.FirstOrDefault().State,
                                    Specialty = string.Join(Environment.NewLine, practitionerRole.Specialty.Select(s => s.Text))
                                };
                                foreach(var organization in organizations)   
                                {
                                    var organizationRef = "Organization/" + organization.Id;
                                    if(organizationRef.Equals(practitionerRole.Organization.Url.ToString()))
                                    {
                                        newPractitionerNearInLoop.Telecom =  string.Join(Environment.NewLine, organization.Telecom.Select(t => t.Value + " (" + t.Use + ")"));
                                        newPractitionerNearInLoop.Address = organization.Name + " " +
                                                    string.Join(Environment.NewLine, organization.Address.FirstOrDefault().Line) +  " " +
                                                    organization.Address.FirstOrDefault().City + " "+
                                                    organization.Address.FirstOrDefault().PostalCode + " " +
                                                    organization.Address.FirstOrDefault().State;
                                        break;

                                    }
                                    


                                }
                                practitionersNear.Add(newPractitionerNearInLoop);

                          }

                          
                          
                          

                        }
                    }
                    if(!foundPractitionerRole) 
                             practitionersNear.Add(newPractitionerNear);
                }


                return practitionersNear;
               
       
            }
            catch (FhirOperationException Exc)
            {
                return new List<PractitionersNear>();
            }


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

        public string GetEthnicity(Hl7.Fhir.Model.Patient p)
        {
                
                string ExtList = "";
                //Extension ComplexEx = p.GetExtension("http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");
                Extension ComplexEx = p.GetExtension("http://hl7.org/fhir/us/core-r4/StructureDefinition/us-core-ethnicity");
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
                                ExtList = ExtList +  MyDisplay +" - ";
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
                        if(c.System == ContactPointSystem.Phone)
                        {
                             if(string.IsNullOrEmpty(te))
                                {
                                    te=c.Value + " (" + c.Use + ") ";
                                }
                                else
                                {
                                    te = te + ", " + c.Value + " (" + c.Use + ") ";
                                }
                        }
                       
                        
                    }
                return te;

        }

        public string GetEmail(Hl7.Fhir.Model.Patient p)
        {
                string te="";
                foreach( ContactPoint c in p.Telecom)
                    {
                        if(c.System == ContactPointSystem.Email)
                        {
                             if(string.IsNullOrEmpty(te))
                                {
                                    te=c.Value + " (" + c.Use + ") ";
                                }
                                else
                                {
                                    te = te + ", " + c.Value + " (" + c.Use + ") ";
                                }
                        }
                       
                        
                    }
                return te;

        }

        public string GetFhirFamily(Patient p, string dbFamilyName)
        {
            string fhirFamily = "";
            
            foreach(var name in p.Name)
            {
                if(name.Family == dbFamilyName)
                {
                   //Fhir server and local db details match
                    
                    fhirFamily = name.Family;
                    return fhirFamily;
                }
                else
                {
                    //Return back the list of family names
                    fhirFamily = fhirFamily == "" ? name.Family : fhirFamily + ", " + name.Family;
                }
            }
            return fhirFamily;
        }

        public string GetFhirGiven(Patient p, string dbGivenName)
        {
            string fhirGiven = "";
            
            foreach(var name in p.Name)
            {
                foreach(var given in name.Given)
                {
                    if(given.Equals(dbGivenName))
                    {
                        return given;
                    }
                    else
                    {
                        fhirGiven = fhirGiven == "" ? given : fhirGiven + ", " + given;
                    }
                }
            }
            return fhirGiven;
        }

        public DateTime GetFhirDateOfBirth(Patient p)
        {
            return Convert.ToDateTime(p.BirthDate);

        }

    }
        
       
}
