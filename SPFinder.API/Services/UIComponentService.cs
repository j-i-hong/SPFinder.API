using SPFinder.API.Domain.Models;
using SPFinder.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPFinder.API.Services
{
    public class UIComponentService : IUIComponentService
    {
        public async Task<IEnumerable<UIComponent>> GetIndustries()
        {
            IEnumerable<UIComponent> industries = new List<UIComponent>
            {
                new UIComponent{ Id = 1, Description = "Aerospace"},
                new UIComponent{ Id = 2, Description = "Alcohol Beverage"},
                new UIComponent{ Id = 3, Description = "Apparel"},
                new UIComponent{ Id = 4, Description = "Automotive"}, //
                new UIComponent{ Id = 5, Description = "Chemicals"},
                new UIComponent{ Id = 6, Description = "Consumer Electronics"},
                new UIComponent{ Id = 7, Description = "Consumer Packaged Goods (CPG)"},
                new UIComponent{ Id = 8, Description = "Defense"},
                new UIComponent{ Id = 9, Description = "Fast Moving Consumer Goods"},
                new UIComponent{ Id = 10, Description = "Financial Services"},
                new UIComponent{ Id = 11, Description = "Foodservice"},
                new UIComponent{ Id = 12, Description = "Fresh Foods"},
                new UIComponent{ Id = 13, Description = "Hardlines"},
                new UIComponent{ Id = 14, Description = "Healthcare"},
                new UIComponent{ Id = 15, Description = "Retail"},
                new UIComponent{ Id = 16, Description = "Retail Grocery"},
            };

            return  industries;
        }

        public async Task<IEnumerable<UIComponent>> GetServices()
        {
            IEnumerable<UIComponent> services = new List<UIComponent>
            {
                new UIComponent{ Id = 1, Description = "B2B Gateway"},
                new UIComponent{ Id = 2, Description = "Barcode Printing Service"},
                new UIComponent{ Id = 3, Description = "Barcode verification service"},
                new UIComponent{ Id = 4, Description = "Business Case Development"}, //
                new UIComponent{ Id = 5, Description = "Coupon Clearing"},
                new UIComponent{ Id = 6, Description = "Coupon Help"},
                new UIComponent{ Id = 7, Description = "Data Quality Service"},
                new UIComponent{ Id = 8, Description = "DataBar Support"},
                new UIComponent{ Id = 9, Description = "EDI"},
                new UIComponent{ Id = 10, Description = "Equipment Provider"},
                new UIComponent{ Id = 11, Description = "IT In Store Intelligence"},
                new UIComponent{ Id = 12, Description = "IT Network Security"},
                new UIComponent{ Id = 13, Description = "IT Services"},
                new UIComponent{ Id = 14, Description = "Label/Barcode design services"},
                new UIComponent{ Id = 15, Description = "Managed File Transfer as a service (MFTaas) for B2B"},
                new UIComponent{ Id = 16, Description = "Package Measurement Service"},
                new UIComponent{ Id = 17, Description = "Packing"},
                new UIComponent{ Id = 18, Description = "Printing"},
                new UIComponent{ Id = 19, Description = "Project Management"},
                new UIComponent{ Id = 20, Description = "Recall Support"},
                new UIComponent{ Id = 21, Description = "Repro"},
                new UIComponent{ Id = 22, Description = "Reproduction Service"},
                new UIComponent{ Id = 23, Description = "Site Surveys"},
                new UIComponent{ Id = 24, Description = "Transportation Management"},
                new UIComponent{ Id = 25, Description = "UDI"},
                new UIComponent{ Id = 26, Description = "VAN Services"},
                new UIComponent{ Id = 27, Description = "Warehouse Management"},
            };

            return services;
        }

        public async Task<IEnumerable<UIComponent>> GetGS1USCertifiedServices()
        {
            IEnumerable<UIComponent> industries = new List<UIComponent>
            {
                new UIComponent{ Id = 1, Description = "GS1 US Certified Services"},
                new UIComponent{ Id = 2, Description = "GS1 Standards Professional"},
                new UIComponent{ Id = 3, Description = "GS1 Package Measurement Rules Professional"},
                new UIComponent{ Id = 4, Description = "GS1 US Digital Listing Content Professional"},
                new UIComponent{ Id = 5, Description = "GS1 US National Data Quality Program Certified Auditor"},
                new UIComponent{ Id = 6, Description = "GS1 US Certified Content Provider Program"},
                new UIComponent{ Id = 7, Description = "GS1 US National Data Quality Certified Auditor Program"},
                new UIComponent{ Id = 8, Description = "GS1 US Rx EPCIS Conformance Testing Program"},
            };

            return industries;
        }

        public async Task<IEnumerable<UIComponent>> GetHardwareOptions()
        {

            IEnumerable<UIComponent> industries = new List<UIComponent>
            {
                new UIComponent{ Id = 1, Description = "Antenna"},
                new UIComponent{ Id = 2, Description = "Conveyor Portal"},
                new UIComponent{ Id = 3, Description = "Dock Door Portal"},
                new UIComponent{ Id = 4, Description = "Labels"},
                new UIComponent{ Id = 5, Description = "Phone Camera"},
                new UIComponent{ Id = 6, Description = "Printers"},
                new UIComponent{ Id = 7, Description = "Readers"},
                new UIComponent{ Id = 8, Description = "Scanners"},
                new UIComponent{ Id = 9, Description = "Tags"},
                new UIComponent{ Id = 10, Description = "Verifiers"},
            };

            return industries;
        }

        public async Task<IEnumerable<UIComponent>> GetSoftwareOptions()
        {
            IEnumerable<UIComponent> industries = new List<UIComponent>
            {
                new UIComponent{ Id = 1, Description = "Asset & Inventory Management"},
                new UIComponent{ Id = 2, Description = "B2B Gateway Software"},
                new UIComponent{ Id = 3, Description = "Business Intelligence"},
                new UIComponent{ Id = 4, Description = "Client Server Applications"},
                new UIComponent{ Id = 5, Description = "Data Accuracy"},
                new UIComponent{ Id = 6, Description = "Data Completeness"},
                new UIComponent{ Id = 7, Description = "Data Consistency"},
                new UIComponent{ Id = 8, Description = "Data Integration Tools (BI & complex event processing)"},
                new UIComponent{ Id = 9, Description = "Data Quality"},
                new UIComponent{ Id = 10, Description = "Data Standards"},
                new UIComponent{ Id = 11, Description = "Data Timeliness"},
                new UIComponent{ Id = 12, Description = "Datapool"},
                new UIComponent{ Id = 13, Description = "Datapool Item AuthorizationSynchronization"},
                new UIComponent{ Id = 14, Description = "Datapool Price Synchronization"},
                new UIComponent{ Id = 15, Description = "Digital Coupon"},
                new UIComponent{ Id = 16, Description = "EDI Documenting & guideline editing tools"},
                new UIComponent{ Id = 17, Description = "EDI Translation Tools"},
                new UIComponent{ Id = 18, Description = "ERP Software"},
                new UIComponent{ Id = 19, Description = "Global Trade Compliance"},
                new UIComponent{ Id = 20, Description = "Global Trade Management"},
                new UIComponent{ Id = 21, Description = "Global/International Logistics"},
                new UIComponent{ Id = 22, Description = "Hospital Software"},
                new UIComponent{ Id = 23, Description = "Images Provider"},
                new UIComponent{ Id = 24, Description = "Internet Application"},
                new UIComponent{ Id = 25, Description = "Inventory Management"},
                new UIComponent{ Id = 26, Description = "Managed File Transfer for B2B"},
                new UIComponent{ Id = 27, Description = "Middleware"},
                new UIComponent{ Id = 28, Description = "Mobile Asset Optimization"},
                new UIComponent{ Id = 29, Description = "Mobile Internet Application"},
                new UIComponent{ Id = 30, Description = "Order to Cash"},
                new UIComponent{ Id = 31, Description = "Pharmacy Software"},
                new UIComponent{ Id = 32, Description = "Phone Application"},
                new UIComponent{ Id = 33, Description = "POS Software"},
                new UIComponent{ Id = 34, Description = "Printer Drivers (Windows)"},
                new UIComponent{ Id = 35, Description = "Procurement"},
                new UIComponent{ Id = 36, Description = "Product Information Management/MDM"},
                new UIComponent{ Id = 37, Description = "Product Information Provider"},
                new UIComponent{ Id = 38, Description = "Product Line Management"},
                new UIComponent{ Id = 39, Description = "Retail Demand Intelligence"},
                new UIComponent{ Id = 40, Description = "Sales & Operations Planning (S&OP)"},
                new UIComponent{ Id = 41, Description = "Supply Chain Network Design/Planning"},
                new UIComponent{ Id = 42, Description = "Supply Chain Planning"},
                new UIComponent{ Id = 43, Description = "SW Applications"},
                new UIComponent{ Id = 44, Description = "Track and Trace"},
                new UIComponent{ Id = 45, Description = "Transportation Management Systems"},
                new UIComponent{ Id = 46, Description = "VAN"},
                new UIComponent{ Id = 47, Description = "Warehouse Management"},
                new UIComponent{ Id = 48, Description = "XML Validating and editing tools"}
            };

            return industries;
        }
    }
}
