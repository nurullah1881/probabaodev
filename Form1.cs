using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            savas.Hide();
        }

        private void i_inonu_kapat_Click(object sender, EventArgs e)
        {
            savas.Hide();
        }

        private void i_inonu_Click_1(object sender, EventArgs e)
        {
            savas.Show();

            label6.Text = "Birinci İnönü Muharebesi";
            ozetText.Text = "     Yunan kuvvetleriyle İnönü mevzilerinde savunmada olan Ankara Hükümeti kuvvetleri arasında \nyapılan muharebedir. " +
                "6 Ocak 1921 tarihine kadar Uşak ve Bursa bölgesinde hazırlıklarını sürdüren \nYunanlar, Türk-Batı Cephesi birliklerinin Çerkez Ethem Kuvvetlerinin Tenkili harekâtı ile meşgul \nolmasından da faydalanarak, " +
                "İnönü-Eskişehir istikametinde taarruza başladılar." +
                "\n6-9 Ocak 1921 tarihleri arasındaki muharebeler, örtme ve emniyet kuvvetleri harekâtı şeklinde \ncereyan etti. İnönü mevzilerindeki muharebeler 10 Ocak 1921 tarihinde başlamış, \nYunan kuvvetlerinin taarruz çıkış hatlarına çekildiği 11 Ocak 1921 tarihine kadar sürmüştür." +
                "\n\n\n\nTürk tarafı, her ne kadar sürekli geri çekilmiş olsa da, Yunan kuvvetlerinin Eskişehir \nyönünde ilerlemesini durdurmuş olduklarını ileri sürerek savaşı, " +
                "kesin bir \nzafer olarak tanımlamaktadırlar. Yunan tarafı ise, harekâtın zaten sınırlı hedefli olduğu \nve planlanan hedeflere ulaşıldığı gerekçesiyle bunu reddetmektedirler. \nBu tartışmalar günümüzde de sürmektedir. \n\n\n\nSavaşı, Türk tarafının zaferi olarak değerlendiren çevrelerde ileri sürülenlerin görüşler " +
                "temelde, Türk tarafının belirli bir miktar malzeme kaybetmesine, " +
                "\nbölgedeki demiryollarının imha edilmiş olmasına karşın, toprak kaybetmediği olgusuna dayanmaktadır. " +
                "\nYunan kuvvetlerinin geri çekilmesinin ise, plan ne olursa olsun, gerek Türk, gerek dünya ve gerekse de Yunan kamuoyunda, \nYunan kuvvetlerinin zaferi olarak algılanmadığı ileri sürülmektedir. Çünkü, savaş sonrasında, kazanan tarafın, karşı tarafa iradesini kabul ettirdiği bir antlaşma yoktu." +
                "\n\nSavaştan hemen sonra Türk tarafında durum bu şekilde değerlendirilmiş, Ankara'da geniş çaplı kutlamalar yapılmıştır. Gerek Türk kamuoyu, \ngerekse de Türk Silahlı Kuvvetleri, muharebeleri kesin bir zafer olarak değerlendirmiştir.";

            pictureBox3.ImageLocation = "C:/Users/user/Desktop/probabaodev-main/Resimler/IIinonu.jpg";
}

        private void ii_inonu_Click(object sender, EventArgs e)
        {
            savas.Show();

            label6.Text = "İkinci İnönü Muharebesi";
            pictureBox3.ImageLocation = "C:/Users/user/Desktop/probabaodev-main/Resimler/2.inonu-savasi.jpg";

            ozetText.Text = "   Birinci İnönü Muharebesi'nden kazanç sağlayamayan ve Türk kuvvetlerinin güçlenmesine \nimkân vermeden imhasını sağlamak; Eskişehir ve Afyon stratejik bölgesini ele geçirmek, \nSevr Antlaşması hükümlerini zorla Millî Hükümete kabul ettirmek maksadıyla 23 Mart 1921 " +
                "\ngünü ileri harekata geçen Bursa bölgesine çekilen 3. Yunan Kolordusu ve Uşak bölgesinde \nbulunan 1. Yunan Kolordusu Londra Konferansı'na gitmek için hazırlanan Türk temsilcileri \ndaha yoldayken, tüm barış kapılarını kapayıp, biri Afyonkarahisar diğeri Eskişehir istikametinde \niki koldan saldırıyı başlattılar." +
                "\n\n\nYunan birlikleri muharebenin ilk dört gününde çok başarılı olarak 24 Mart'ta Dumlupınar'ı, \n27 Mart'ta da Afyon'u ele geçirdiler. Eskişehir yönünde gelişen Yunan saldırısı ise \nBirinci İnönü Muharebesi'nde takip edilen yoldan ilerlemekteydi. \nİnönü mevkiindeki çatışmalar 27 Mart sabahı başladı. " +
                "\n\n\nYunan ordusunun ilk günlerde etkili taarruzlar yapması üzerine bu sıkışık anda \ntakviye olmak üzere TBMM'nde alınan karar doğrultusunda Meclis Muhafız Taburu ile birlikte Millî Savunma Bakanı Fevzi Paşa cepheye gitti. \nMevzilerin savunulmasında hiç zaaf göstermeyen ve emirlerinde son derece kesin davranan " +
                "Cephe Komutanı İsmet Paşa'nın başarılı karşı taarruz emriyle \ndüşman güçleri geri çekilmek zorunda kaldılar. " +
                "Yunan ordusu bu çekilişi sırasında Türk süvarilerinin ısrarlı takipleri sonucunda ağır kayıplar vermiştir. " +
                "\nBuna karşılık Yunan ordusunun güney cephesinde yaptığı taarruz gelişme göstermiş, Afyonu işgal eden Yunan kuvvetleri Çay-Bolvadin hattına kadar ilerlemişlerdi. \nAncak Yunan birlikleri 30 Mart'ta yaptıkları ikinci saldırıda da geri püskürtülünce güneyde Afyon şehrinden çekilmek durumunda kaldılar. \nGeri çekilen Yunan " +
                "ordusuna Türk süvarileri tarafından Yenişehir ovasında kuvvetli bir darbe indirilmiştir. " +
                "\n\n\nYunanların mağlubiyeti Batı Cephesi Komutanı İsmet Paşa tarafından 1 Nisan 1921'de TBMM Başkanı Mustafa Kemal Paşa'ya telgrafla duyurulur. " +
                "\n \"Düşman, binlerce ölüsüyle doldurduğu savaş meydanını silahlarımıza bırakmıştır\" diye çekilen telgrafa Mustafa Kemal Paşa cevaben, \n\"Siz orada yalnız düşmanı değil milletin makus talihini de yendiniz. İstila altındaki topraklarımızla beraber bütün vatan, \nbugün en ücra köşelerine kadar zaferinizi kutluyor\" diye " +
                "yazmıştır. \n\n\n\nBu savaşta ölen askerler Bilecik şehri sınırlarında bulunan İnönü Şehitliği'nde gömülüdür.";
        }

        private void kutahya_Click(object sender, EventArgs e)
        {
            savas.Show();

            label6.Text = "Kütahya - Eskişehir Muharebesi";
            pictureBox3.ImageLocation = "C:/Users/user/Desktop/probabaodev-main/Resimler/eskisehir.jpg";

            ozetText.Text = "   Yunan kuvvetleri, Aslıhanlar ve Dumlupınar Muharebeleri \nile Kütahya-Eskişehir Muharebeleri arasındaki üç aylık zaman içinde, Anadolu'daki kuvvetlerini \n11 tümen ve 1 süvari tugayına çıkartarak daha da güçlenmiş bir durumda 10 Temmuz 1921'de \nBursa-Eskişehir; Bursa-Tavşanlı-Kütahya; Uşak-Dumlupınar-Seyitgazi " +
                "istikametlerinde \nüç ayrı koldan taarruza geçtiler." +
                "\n\nTürk Ordusu'nun imha edilmesini ve Afyon, Eskişehir, Kütahya gibi stratejik noktaların işgalini \namaçlayan Yunanlar; İnönü ve Kütahya tahkim edilmiş mevzilerine çatmak yerine, \nzayıf kuvvetlerle tutulmuş olan Türk Kuvvetlerini güney kanattan kuşatmak üzere \nharekâta başladılar." +
                "\n\nI. ve II. İnönü Muharebelerinin aksine, Bursa bölgesi'nde hareketsiz görünen Yunan Ordusu, \nAfyon cephesinde başlangıçta 12., " +
                "müteakiben de 2. Türk Kolorduları bölgesine taarruza geçti. \n13 Temmuz 1921'de Afyon'u işgal eden ve 12. Kolordu'ya büyük zayiat verdirerek Afyon doğusuna \nçekilmeye zorlayan Yunanlar, müteakiben taarruzlarını Altıntaş-Seyitgazi \nistikametinde yoğunlaştırdılar. \n15 Temmuz 1921'de 4. Tümen komutanı Yarbay Mehmet Nâzım Bey Yumruçal'da öldü." +
                " \n\n\nYunan birlikleri 17 Temmuz'da İsmet Paşa komutasındaki Garp Cephesi kuvvetlerini, Mehmet Nazım Bey'in öldüğü Yumruçal-Nasuhçal civarında \ncepheyi yarıp Kütahya'yı ele geçirdi. Aynı gün Fevzi Paşa ile birlikte cepheye gelerek Garp Cephesindeki TBMM kuvvetlerinin kuşatma tehdidi altına girdiğini gören \nMustafa Kemal Paşa " +
                "Türk ordusunun çekilmesini emretmek zorunda kaldı: " +
                "\nBatı Cephesi birlikleri önce süratle Eskişehir-Seyitgazi hattına, daha sonra da Sakarya Nehri doğusuna ricat edecekti. \nBu ricat, Türk Ordusu'nun elde kalmasını sağlayarak kuşatılarak yok edilmesini engelledi." +
                "\n\nKomutayı ise, o zamana kadar Garp Cephesinin başında olan İsmet Paşa yerine bizzat Mustafa Kemal Paşa ve Fevzi Paşa ele aldı. \nAskerliğin gereği bunu gerektiriyordu ve sür'atle yerine getirilmeliydi. 19 Temmuz günü Eskişehir de düşünce, Fahrettin Bey komutasındaki 5. Süvari Grubu ve \n1. Gruba bağlı Türk birlikleri " +
                "Sakarya Nehrinin doğusuna çekildi. TBMM, 3 Ağustos 1921'de İsmet Paşa'yı Genelkurmay Başkanlığı görevinden azlederek, " +
                "\naynı zamanda Başbakan ve Millî Savunma Bakanı da olan Fevzi Paşa'yı bu vazifeyle de görevlendirdi. " +
                "Aynı zamanda Meclis Başkanı Mustafa Kemal Paşa'yı \nTürk Ordusu Başkomutanlığı'na atadı.";
        }
        private void sakarya_Click(object sender, EventArgs e)
        {
            savas.Show();

            label6.Text = "Sakarya Meydan Muharebesi";
            pictureBox3.ImageLocation = "C:/Users/user/Desktop/probabaodev-main/Resimler/Battle_of_Sakarya_1921.jpg";

            ozetText.Text = "  TBMM ordusu, Kütahya-Eskişehir Muharebeleri'ndeki yenilgisinden sonra cephe kritik bir \nduruma düşmüştü. " +
                "Cepheye gelerek durumu yerinde gören ve komutayı eline alan TBMM Başkanı \nve Başkomutan Mustafa Kemal Paşa ile İcra Vekilleri Heyeti Başkanı Fevzi Paşa, " +
                "\nBatı Cephesi birliklerinin Yunan ordusuyla arada büyük bir mesafe bırakılarak \nSakarya Nehri'nin doğusuna çekilmesine ve savunmayı bu hatta devam ettirmesine karar verdiler." +
                "\r\n\r\nGazi Mustafa Kemal Paşa; " +
                "\n\"Hatt-ı müdafaa yoktur; sath-ı müdafaa vardır. O satıh bütün vatandır. " +
                "\nVatanın her karış toprağı vatandaş kanıyla sulanmadıkça vatan terk olunamaz. " +
                "\nOnun için küçük, büyük her cüzütamı (birlik), bulunduğu mevziden atılabilir." +
                "\nFakat küçük, büyük her cüzütam ilk durabildiği noktada, tekrar düşmana karşı cephe teşkil edip \nmuharebeye devam eder. " +
                "Yanındaki cüzütamın çekilmeye mecbur olduğunu gören cüzütamlar, " +
                "\nona tabi olamaz. Bulunduğu mevzide nihayete kadar sebat ve mukavemete mecburdur.\" " +
                "\nemrini vererek muharebeyi geniş bir alana yaydı. \nBöylece Yunan kuvvetleri de karargâhlarından uzaklaşıp bölünmüş olacaktı." +
                "\n\n\n\nTBMM, 3 Ağustos 1921'de Genelkurmay Başkanı İsmet Paşa'yı azlederek, aynı zamanda Başvekil ve Millî Müdafaa Vekili de olan Fevzi Paşa'yı bu makama da atadı.\n22 Temmuz 1921'de Sakarya Nehri doğusuna çekilmeye başlayan Türk ordusu, güneyden kuzeye 5. Süvari Kolordusu (Çal Dağı güneyinde), " +
                "\n12, 1, 2, 3 ve 4. gruplar ile Mürettep Kolordu birinci hatta olacak şekilde tertiplendi. Çekilişin hızlı bir şekilde tamamlanmasından sonra Yunan birlikleri \ntaarruz pozisyonu için tam dokuz gün Türk birlikleri ile karşılaşmadan yürüdü. Bu yürüyüşün hangi yöne doğru olduğu Türk keşif birlikleri tarafından " +
                "\ntespit edilerek cephe komutanlığına bildirildi. Bu savaşın kaderini belirleyecek stratejik hatalardan biri oldu. " +
                "\n\n\nYunan taarruzu baskın olma özelliğini kaybetti. Ancak 14 Ağustos'ta ileri harekâta geçen Yunan ordusu, 23 Ağustos'tan itibaren 3. Kolordu ile Sakarya Nehri \ndoğusundaki Türk kuvvetlerini tespit, 1. Kolordu ile Haymana istikametinde, 2. Kolordu ile Mangal Dağı güneydoğusunda kuşatıcı taarruza başladı. " +
                "\nFakat bu taarruzlarında başarısız oldular. Kuşatma taarruzunda başarı sağlayamayan Yunan kuvvetleri, sıklet merkezini ortaya kaydırarak savunma mevzilerini \nHaymana istikametinde yarmak istedi. 2 Eylül'de Yunan birlikleri, Ankara'ya kadar en stratejik dağ olan Çal Dağı'nın tamamını ele geçirdi. \nFakat Türk birlikleri Ankara'ya kadar geri çekilmeyerek alan savunması yapmaya başladı. Yunan birlikleri Ankara'ya 50 km kalacak derecede bazı ilerlemeler \nsağlasa da Türk birliklerinin yıpratıcı savunmasından kurtulamadı. Ayrıca 5. Türk Süvari Kolordusu tarafından cephe ikmal hatlarına yapılan taarruzlar \nYunan taarruzunun hızının kırılmasında önemli etkenlerden biri oldu. " +
                "\nYunan ordusu 9 Eylül'e kadar süren yarma teşebbüsünde de başarılı olamayınca, bulunduğu hatlarda kalarak savunmaya karar verdi." +
                "\n\nYunan ordusu, Ankara'nın 50 km kadar yakınından geri çekildi.\nYunan ordusu geri çekilirken Türklerin kullanabileceği hiçbir şey bırakmamak için özen gösterdi. Demir yollarını ve köprüleri havaya uçurdu ve birçok köyü yaktı.";
        }

        private void taaruz_Click(object sender, EventArgs e)
        {
            savas.Show();

            label6.Text = "Büyük Taarruz";
            pictureBox3.ImageLocation = "C:/Users/user/Desktop/probabaodev-main/Resimler/Commanders_of_the_Turkish_War_of_Independence.jpg";
            ozetText.Text = "Türk Ordusu Sakarya Meydan Muharebesi'ni kazanmış olsa da " +
                "\nYunan ordularını savaşa zorlayarak yok edecek bir durumda değildi. " +
                "\nTürk ordusunun bir taarruza girişmesi için büyük eksikleri vardı. Bunların giderilmesi için halktan " +
                "\nson bir kez özveride bulunması istendi. Bütün mali kaynaklar son sınıra kadar zorlandı ve " +
                "\nhemen hazırlıklara başlandı; subaylar ve askerler taarruz için eğitilmeye başlandı." +
                "\nÜlkenin tüm kaynakları ordunun emrine verildi. Muharebelerin fiilen sona erdiği Doğu ve" +
                "\nGüney cephesindeki birlikler de Batı cephesine kaydırıldı. Öte yandan İstanbul'da da " +
                "\nTürk kurtuluş mücadelesine destek veren dernekler İtilaf Devletleri'nin silah depolarından kaçırdıkları " +
                "\nsilahları Ankara'ya gönderdiler. Türk ordusu ilk kez taarruza geçecekti ve bu yüzden sayıca " +
                "\nYunan birliklerinden üstün olmak zorundaydı. \n\nAnadolu'da bu dönemde 200.000 Yunan askeri vardı." +
                "\n\nTürk ordusu da bir yıllık hazırlık sonucunda ordudaki asker sayısını 186.000'e yükselterek " +
                "\nYunan birliklerine yaklaştı. Ancak Türk ordusu tüm bu çabalara rağmen süvari birlikleri dışında " +
                "\nYunan birliklerine bir üstünlük sağlayamamış, ancak bir denge kurulabilmişti." +
                "\n\n26 Ağustos gecesi 5. Süvari Kolordusu, Ahır Dağları üzerindeki Yunanların gece savunmadığı Ballıkaya mevkiinden sızma yaparak Yunan hatlarının gerisine " +
                "\nintikale başladı. İntikal bütün gece sabaha kadar sürdü. Yine 26 Ağustos sabahı Başkomutan Mustafa Kemal Paşa, yanında Genelkurmay Başkanı Fevzi Paşa ve " +
                "\nBatı Cephesi Komutanı İsmet Paşa ile birlikte muharebeyi idare etmek üzere Kocatepe'deki yerini aldı. Büyük Taarruz burada başlayarak, " +
                "\ntopçuların sabah saat 04.30'da tanzim ateşi ile başlayan harekât, saat 05.00'te önemli noktalara yoğun topçu ateşi ile devam etti. " +
                "\nTürk piyadeleri, sabah 06.00'da Tınaztepe'ye hücum mesafesine yaklaşarak tel örgüleri aşıp Yunan askerini süngü hücumu ile temizledikten sonra" +
                "\nTınaztepe'yi ele geçirdi. Bundan sonra saat 09.00’da Belentepe, daha sonra Kalecik - Sivrisi ele geçirildi. Taarruzun birinci günü, sıklet merkezindeki 1. Ordu Birlikleri, " +
                "\nBüyük Kaleciktepe'den Çiğiltepe'ye kadar 15 kilometrelik bir bölgede düşmanın birinci hat mevzilerini ele geçirdi. " +
                "\n5. Süvari Kolordusu düşman gerilerindeki ulaştırma kollarına başarılı taarruzlarda bulunarak, 2. Ordu da cephede tespit görevini aksatmadan sürdürdü." +
                "\n\n27 Ağustos Pazar sabahı gün ağarırken Türk ordusu bütün cephelerde yeniden taarruza geçti. " +
                "\nBu taarruzlar çoğunlukla süngü hücumlarıyla ve insanüstü çabalarla gerçekleştirildi. Aynı gün Türk birlikleri Afyonkarahisar'ı geri aldı. " +
                "\nBaşkomutanlık Karargâhı ile Batı Cephesi Komutanlığı Karargâhı Afyonkarahisar'a taşındı.";
        }

    }
}


//ig @foaqen