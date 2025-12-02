namespace VikashEngineeringWorksShop.Services;

public static class Translations
{
    private static readonly Dictionary<string, Dictionary<string, string>> _translations = new()
    {
        ["en"] = new Dictionary<string, string>
        {
            // Navigation
            ["Home"] = "Home",
            ["Services"] = "Services",
            ["Products"] = "Products",
            ["Gallery"] = "Gallery",
            ["About"] = "About",
            ["Contact"] = "Contact",
            ["Vikash Eng. Work Shop"] = "Vikash Eng. Work Shop",
            
            // Footer
            ["Quick Links"] = "Quick Links",
            ["About Us"] = "About Us",
            
            // Services
            ["CNC Machining"] = "CNC Machining",
            ["Fabrication"] = "Fabrication",
            ["Maintenance"] = "Maintenance",
            ["Consulting"] = "Consulting",
            
            // Gallery
            ["Project Showcase"] = "Project Showcase",
            ["Our Gallery"] = "Our Gallery",
            ["Explore our engineering excellence through our completed projects and manufacturing capabilities"] = "Explore our engineering excellence through our completed projects and manufacturing capabilities",
            ["All"] = "All",
            ["Workshop"] = "Workshop",
            ["Manufacturing"] = "Manufacturing",
            ["Projects"] = "Projects",
            ["Facilities"] = "Facilities",
            ["No items found in this category"] = "No items found in this category",
            
            // Home Page
            ["Premium Industrial Solutions"] = "Premium Industrial Solutions",
            ["Engineering"] = "Engineering",
            ["Excellence"] = "Excellence",
            ["We provide high-quality machinery, precision tools, and custom fabrication services tailored to your industrial needs."] = "We provide high-quality machinery, precision tools, and custom fabrication services tailored to your industrial needs.",
            ["View Catalog"] = "View Catalog",
            ["Contact Us"] = "Contact Us",
            ["Who We Are"] = "Who We Are",
            ["Mastering the Art of Industrial Fabrication"] = "Mastering the Art of Industrial Fabrication",
            ["Vikash Engineering Works Shop is a pioneer in delivering top-tier engineering solutions. From heavy machinery to precision tools, we ensure that every project meets the highest industry standards of quality, safety, and durability."] = "Vikash Engineering Works Shop is a pioneer in delivering top-tier engineering solutions. From heavy machinery to precision tools, we ensure that every project meets the highest industry standards of quality, safety, and durability.",
            ["ISO 9001 Certified Quality"] = "ISO 9001 Certified Quality",
            ["24/7 Maintenance Support"] = "24/7 Maintenance Support",
            ["Custom Machinery Design"] = "Custom Machinery Design",
            ["Read Our Story"] = "Read Our Story",
            ["Years of"] = "Years of",
            ["Experience"] = "Experience",
            ["Projects Completed"] = "Projects Completed",
            ["Happy Clients"] = "Happy Clients",
            ["Expert Engineers"] = "Expert Engineers",
            ["Awards Won"] = "Awards Won",
            ["Our Services"] = "Our Services",
            ["We provide comprehensive maintenance, custom fabrication, CNC machining, and emergency repair solutions designed to keep your operations running smoothly."] = "We provide comprehensive maintenance, custom fabrication, CNC machining, and emergency repair solutions designed to keep your operations running smoothly.",
            ["Explore Services"] = "Explore Services",
            ["Our Products"] = "Our Products",
            ["Browse our wide range of engineering products including heavy equipment, hydraulic systems, industrial gears, and a complete spare parts catalog."] = "Browse our wide range of engineering products including heavy equipment, hydraulic systems, industrial gears, and a complete spare parts catalog.",
            ["View Product Catalog"] = "View Product Catalog",
            
            // Services Page
            ["Our Services"] = "Our Services",
            ["Comprehensive Engineering Solutions"] = "Comprehensive Engineering Solutions",
            ["Precision CNC machining services for complex parts and components. Our state-of-the-art equipment ensures accuracy and consistency in every project."] = "Precision CNC machining services for complex parts and components. Our state-of-the-art equipment ensures accuracy and consistency in every project.",
            ["3-Axis & 5-Axis Machining"] = "3-Axis & 5-Axis Machining",
            ["Prototype Development"] = "Prototype Development",
            ["Quality Assurance"] = "Quality Assurance",
            ["Learn More"] = "Learn More",
            ["Custom Fabrication"] = "Custom Fabrication",
            ["Custom fabrication services for specialized engineering requirements. From design to completion, we handle projects of all sizes."] = "Custom fabrication services for specialized engineering requirements. From design to completion, we handle projects of all sizes.",
            ["Metal Fabrication"] = "Metal Fabrication",
            ["Welding Services"] = "Welding Services",
            ["Custom Design"] = "Custom Design",
            ["Maintenance & Repair"] = "Maintenance & Repair",
            ["Expert maintenance and repair services for all engineering equipment. 24/7 support to keep your operations running smoothly."] = "Expert maintenance and repair services for all engineering equipment. 24/7 support to keep your operations running smoothly.",
            ["Preventive Maintenance"] = "Preventive Maintenance",
            ["Emergency Repairs"] = "Emergency Repairs",
            ["24/7 Support"] = "24/7 Support",
            ["Consultation"] = "Consultation",
            ["Expert consultation services for your engineering projects. Get professional advice and solutions tailored to your needs."] = "Expert consultation services for your engineering projects. Get professional advice and solutions tailored to your needs.",
            ["Project Planning"] = "Project Planning",
            ["Technical Advice"] = "Technical Advice",
            ["Cost Optimization"] = "Cost Optimization",
            ["Ready to Get Started?"] = "Ready to Get Started?",
            ["Contact us today to discuss your engineering needs and discover how we can help bring your project to life."] = "Contact us today to discuss your engineering needs and discover how we can help bring your project to life.",
            ["Contact Us Now"] = "Contact Us Now",
            
            // About Page
            ["Vikash Engineering Works Shop is a leading provider of engineering solutions, committed to delivering excellence in every project. With years of experience in the industry, we have built a reputation for quality, reliability, and customer satisfaction."] = "Vikash Engineering Works Shop is a leading provider of engineering solutions, committed to delivering excellence in every project. With years of experience in the industry, we have built a reputation for quality, reliability, and customer satisfaction.",
            ["Our team of expert engineers and technicians work tirelessly to provide innovative solutions that meet the diverse needs of our customers while maintaining the highest standards of quality and professionalism."] = "Our team of expert engineers and technicians work tirelessly to provide innovative solutions that meet the diverse needs of our customers while maintaining the highest standards of quality and professionalism.",
            ["Our Mission"] = "Our Mission",
            ["To provide high-quality engineering products and services that meet the diverse needs of our customers while maintaining the highest standards of quality and professionalism."] = "To provide high-quality engineering products and services that meet the diverse needs of our customers while maintaining the highest standards of quality and professionalism.",
            ["Our Vision"] = "Our Vision",
            ["To become the most trusted and innovative engineering solutions provider, recognized for excellence, integrity, and customer-centric approach in the industry."] = "To become the most trusted and innovative engineering solutions provider, recognized for excellence, integrity, and customer-centric approach in the industry.",
            ["Our Core Values"] = "Our Core Values",
            ["Quality First"] = "Quality First",
            ["Uncompromising commitment to excellence in every project"] = "Uncompromising commitment to excellence in every project",
            ["Customer Satisfaction"] = "Customer Satisfaction",
            ["Your success is our priority and ultimate goal"] = "Your success is our priority and ultimate goal",
            ["Innovation"] = "Innovation",
            ["Embracing new technologies and creative solutions"] = "Embracing new technologies and creative solutions",
            ["Integrity"] = "Integrity",
            ["Transparent, honest, and ethical in all dealings"] = "Transparent, honest, and ethical in all dealings",
            
            // Contact Page
            ["Get In Touch"] = "Get In Touch",
            ["Have a question or need assistance? We're here to help. Reach out to us and we'll get back to you as soon as possible."] = "Have a question or need assistance? We're here to help. Reach out to us and we'll get back to you as soon as possible.",
            ["Send Us a Message"] = "Send Us a Message",
            ["Name"] = "Name",
            ["Email"] = "Email",
            ["Phone"] = "Phone",
            ["Subject"] = "Subject",
            ["Message"] = "Message",
            ["Send Message"] = "Send Message",
            ["Contact Information"] = "Contact Information",
            ["Address"] = "Address",
            ["Business Hours"] = "Business Hours",
            ["Follow Us"] = "Follow Us",
            ["Stay connected with us on social media for updates and news."] = "Stay connected with us on social media for updates and news.",
            
            // Products Page
            ["Latest Products"] = "Latest Products",
            ["New Arrivals"] = "New Arrivals",
            ["Discover our newest engineering solutions and cutting-edge products"] = "Discover our newest engineering solutions and cutting-edge products",
            ["New"] = "New",
            ["Price Range"] = "Price Range",
            ["All Products"] = "All Products",
            ["Browse our wide range of engineering products and solutions"] = "Browse our wide range of engineering products and solutions",
        },
        ["hi"] = new Dictionary<string, string>
        {
            // Navigation
            ["Home"] = "होम",
            ["Services"] = "सेवाएं",
            ["Products"] = "उत्पाद",
            ["Gallery"] = "गैलरी",
            ["About"] = "के बारे में",
            ["Contact"] = "संपर्क करें",
            ["Vikash Eng. Work Shop"] = "विकाश इंजीनियरिंग वर्कशॉप",
            
            // Footer
            ["Quick Links"] = "त्वरित लिंक",
            ["About Us"] = "हमारे बारे में",
            
            // Services
            ["CNC Machining"] = "सीएनसी मशीनिंग",
            ["Fabrication"] = "निर्माण",
            ["Maintenance"] = "रखरखाव",
            ["Consulting"] = "सलाह",
            
            // Gallery
            ["Project Showcase"] = "परियोजना प्रदर्शनी",
            ["Our Gallery"] = "हमारी गैलरी",
            ["Explore our engineering excellence through our completed projects and manufacturing capabilities"] = "हमारे पूर्ण परियोजनाओं और विनिर्माण क्षमताओं के माध्यम से हमारी इंजीनियरिंग उत्कृष्टता का अन्वेषण करें",
            ["All"] = "सभी",
            ["Workshop"] = "कार्यशाला",
            ["Manufacturing"] = "विनिर्माण",
            ["Projects"] = "परियोजनाएं",
            ["Facilities"] = "सुविधाएं",
            ["No items found in this category"] = "इस श्रेणी में कोई आइटम नहीं मिला",
            
            // Home Page
            ["Premium Industrial Solutions"] = "प्रीमियम औद्योगिक समाधान",
            ["Engineering"] = "इंजीनियरिंग",
            ["Excellence"] = "उत्कृष्टता",
            ["We provide high-quality machinery, precision tools, and custom fabrication services tailored to your industrial needs."] = "हम आपकी औद्योगिक आवश्यकताओं के अनुरूप उच्च गुणवत्ता वाली मशीनरी, सटीक उपकरण और कस्टम निर्माण सेवाएं प्रदान करते हैं।",
            ["View Catalog"] = "कैटलॉग देखें",
            ["Contact Us"] = "संपर्क करें",
            ["Who We Are"] = "हम कौन हैं",
            ["Mastering the Art of Industrial Fabrication"] = "औद्योगिक निर्माण की कला में महारत",
            ["Vikash Engineering Works Shop is a pioneer in delivering top-tier engineering solutions. From heavy machinery to precision tools, we ensure that every project meets the highest industry standards of quality, safety, and durability."] = "विकाश इंजीनियरिंग वर्क्स शॉप शीर्ष स्तरीय इंजीनियरिंग समाधान प्रदान करने में अग्रणी है। भारी मशीनरी से लेकर सटीक उपकरणों तक, हम सुनिश्चित करते हैं कि हर परियोजना गुणवत्ता, सुरक्षा और स्थायित्व के उच्चतम उद्योग मानकों को पूरा करती है।",
            ["ISO 9001 Certified Quality"] = "ISO 9001 प्रमाणित गुणवत्ता",
            ["24/7 Maintenance Support"] = "24/7 रखरखाव सहायता",
            ["Custom Machinery Design"] = "कस्टम मशीनरी डिज़ाइन",
            ["Read Our Story"] = "हमारी कहानी पढ़ें",
            ["Years of"] = "वर्षों का",
            ["Experience"] = "अनुभव",
            ["Projects Completed"] = "पूर्ण परियोजनाएं",
            ["Happy Clients"] = "खुश ग्राहक",
            ["Expert Engineers"] = "विशेषज्ञ इंजीनियर",
            ["Awards Won"] = "पुरस्कार जीते",
            ["Our Services"] = "हमारी सेवाएं",
            ["We provide comprehensive maintenance, custom fabrication, CNC machining, and emergency repair solutions designed to keep your operations running smoothly."] = "हम व्यापक रखरखाव, कस्टम निर्माण, सीएनसी मशीनिंग और आपातकालीन मरम्मत समाधान प्रदान करते हैं जो आपके संचालन को सुचारू रूप से चलाने के लिए डिज़ाइन किए गए हैं।",
            ["Explore Services"] = "सेवाएं देखें",
            ["Our Products"] = "हमारे उत्पाद",
            ["Browse our wide range of engineering products including heavy equipment, hydraulic systems, industrial gears, and a complete spare parts catalog."] = "भारी उपकरण, हाइड्रोलिक सिस्टम, औद्योगिक गियर और पूर्ण स्पेयर पार्ट्स कैटलॉग सहित हमारे इंजीनियरिंग उत्पादों की विस्तृत श्रृंखला ब्राउज़ करें।",
            ["View Product Catalog"] = "उत्पाद कैटलॉग देखें",
            
            // Services Page
            ["Comprehensive Engineering Solutions"] = "व्यापक इंजीनियरिंग समाधान",
            ["Precision CNC machining services for complex parts and components. Our state-of-the-art equipment ensures accuracy and consistency in every project."] = "जटिल भागों और घटकों के लिए सटीक सीएनसी मशीनिंग सेवाएं। हमारे अत्याधुनिक उपकरण हर परियोजना में सटीकता और स्थिरता सुनिश्चित करते हैं।",
            ["3-Axis & 5-Axis Machining"] = "3-एक्सिस और 5-एक्सिस मशीनिंग",
            ["Prototype Development"] = "प्रोटोटाइप विकास",
            ["Quality Assurance"] = "गुणवत्ता आश्वासन",
            ["Learn More"] = "और जानें",
            ["Custom Fabrication"] = "कस्टम निर्माण",
            ["Custom fabrication services for specialized engineering requirements. From design to completion, we handle projects of all sizes."] = "विशेष इंजीनियरिंग आवश्यकताओं के लिए कस्टम निर्माण सेवाएं। डिज़ाइन से लेकर पूर्णता तक, हम सभी आकारों की परियोजनाओं को संभालते हैं।",
            ["Metal Fabrication"] = "धातु निर्माण",
            ["Welding Services"] = "वेल्डिंग सेवाएं",
            ["Custom Design"] = "कस्टम डिज़ाइन",
            ["Maintenance & Repair"] = "रखरखाव और मरम्मत",
            ["Expert maintenance and repair services for all engineering equipment. 24/7 support to keep your operations running smoothly."] = "सभी इंजीनियरिंग उपकरणों के लिए विशेषज्ञ रखरखाव और मरम्मत सेवाएं। आपके संचालन को सुचारू रूप से चलाने के लिए 24/7 सहायता।",
            ["Preventive Maintenance"] = "निवारक रखरखाव",
            ["Emergency Repairs"] = "आपातकालीन मरम्मत",
            ["24/7 Support"] = "24/7 सहायता",
            ["Consultation"] = "परामर्श",
            ["Expert consultation services for your engineering projects. Get professional advice and solutions tailored to your needs."] = "आपकी इंजीनियरिंग परियोजनाओं के लिए विशेषज्ञ परामर्श सेवाएं। अपनी आवश्यकताओं के अनुरूप पेशेवर सलाह और समाधान प्राप्त करें।",
            ["Project Planning"] = "परियोजना योजना",
            ["Technical Advice"] = "तकनीकी सलाह",
            ["Cost Optimization"] = "लागत अनुकूलन",
            ["Ready to Get Started?"] = "शुरू करने के लिए तैयार हैं?",
            ["Contact us today to discuss your engineering needs and discover how we can help bring your project to life."] = "अपनी इंजीनियरिंग आवश्यकताओं पर चर्चा करने और यह पता लगाने के लिए आज ही हमसे संपर्क करें कि हम आपकी परियोजना को जीवंत बनाने में कैसे मदद कर सकते हैं।",
            ["Contact Us Now"] = "अभी संपर्क करें",
            
            // About Page
            ["Vikash Engineering Works Shop is a leading provider of engineering solutions, committed to delivering excellence in every project. With years of experience in the industry, we have built a reputation for quality, reliability, and customer satisfaction."] = "विकाश इंजीनियरिंग वर्क्स शॉप इंजीनियरिंग समाधानों का एक अग्रणी प्रदाता है, जो हर परियोजना में उत्कृष्टता प्रदान करने के लिए प्रतिबद्ध है। उद्योग में वर्षों के अनुभव के साथ, हमने गुणवत्ता, विश्वसनीयता और ग्राहक संतुष्टि के लिए प्रतिष्ठा बनाई है।",
            ["Our team of expert engineers and technicians work tirelessly to provide innovative solutions that meet the diverse needs of our customers while maintaining the highest standards of quality and professionalism."] = "हमारे विशेषज्ञ इंजीनियरों और तकनीशियनों की टीम गुणवत्ता और व्यावसायिकता के उच्चतम मानकों को बनाए रखते हुए हमारे ग्राहकों की विविध आवश्यकताओं को पूरा करने वाले नवीन समाधान प्रदान करने के लिए अथक प्रयास करती है।",
            ["Our Mission"] = "हमारा मिशन",
            ["To provide high-quality engineering products and services that meet the diverse needs of our customers while maintaining the highest standards of quality and professionalism."] = "उच्च गुणवत्ता वाले इंजीनियरिंग उत्पादों और सेवाओं को प्रदान करना जो हमारे ग्राहकों की विविध आवश्यकताओं को पूरा करते हुए गुणवत्ता और व्यावसायिकता के उच्चतम मानकों को बनाए रखें।",
            ["Our Vision"] = "हमारी दृष्टि",
            ["To become the most trusted and innovative engineering solutions provider, recognized for excellence, integrity, and customer-centric approach in the industry."] = "उद्योग में उत्कृष्टता, ईमानदारी और ग्राहक-केंद्रित दृष्टिकोण के लिए मान्यता प्राप्त, सबसे विश्वसनीय और नवीन इंजीनियरिंग समाधान प्रदाता बनना।",
            ["Our Core Values"] = "हमारे मूल मूल्य",
            ["Quality First"] = "गुणवत्ता पहले",
            ["Uncompromising commitment to excellence in every project"] = "हर परियोजना में उत्कृष्टता के प्रति अडिग प्रतिबद्धता",
            ["Customer Satisfaction"] = "ग्राहक संतोष",
            ["Your success is our priority and ultimate goal"] = "आपकी सफलता हमारी प्राथमिकता और अंतिम लक्ष्य है",
            ["Innovation"] = "नवाचार",
            ["Embracing new technologies and creative solutions"] = "नई प्रौद्योगिकियों और रचनात्मक समाधानों को अपनाना",
            ["Integrity"] = "ईमानदारी",
            ["Transparent, honest, and ethical in all dealings"] = "सभी लेन-देन में पारदर्शी, ईमानदार और नैतिक",
            
            // Contact Page
            ["Get In Touch"] = "संपर्क में रहें",
            ["Have a question or need assistance? We're here to help. Reach out to us and we'll get back to you as soon as possible."] = "कोई प्रश्न है या सहायता चाहिए? हम मदद के लिए यहां हैं। हमसे संपर्क करें और हम जल्द से जल्द आपके पास वापस आएंगे।",
            ["Send Us a Message"] = "हमें संदेश भेजें",
            ["Name"] = "नाम",
            ["Email"] = "ईमेल",
            ["Phone"] = "फ़ोन",
            ["Subject"] = "विषय",
            ["Message"] = "संदेश",
            ["Send Message"] = "संदेश भेजें",
            ["Contact Information"] = "संपर्क जानकारी",
            ["Address"] = "पता",
            ["Business Hours"] = "व्यापार घंटे",
            ["Follow Us"] = "हमें फॉलो करें",
            ["Stay connected with us on social media for updates and news."] = "अपडेट और समाचार के लिए सोशल मीडिया पर हमारे साथ जुड़े रहें।",
            
            // Products Page
            ["Latest Products"] = "नवीनतम उत्पाद",
            ["New Arrivals"] = "नए आगमन",
            ["Discover our newest engineering solutions and cutting-edge products"] = "हमारे नवीनतम इंजीनियरिंग समाधान और अत्याधुनिक उत्पादों की खोज करें",
            ["New"] = "नया",
            ["Price Range"] = "मूल्य सीमा",
            ["All Products"] = "सभी उत्पाद",
            ["Browse our wide range of engineering products and solutions"] = "हमारे इंजीनियरिंग उत्पादों और समाधानों की विस्तृत श्रृंखला ब्राउज़ करें",
        }
    };

    public static string Get(string key, string language)
    {
        if (_translations.TryGetValue(language, out var langDict) && 
            langDict.TryGetValue(key, out var value))
        {
            return value;
        }
        return key; // Fallback to key if translation not found
    }
}

