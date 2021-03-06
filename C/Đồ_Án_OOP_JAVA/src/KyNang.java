import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;
import java.io.FileReader;
public abstract class KyNang implements IKyNang
{
	private String sTenKyNang;
	private String sLoaiKyNang;
	private String sMieuTa;
	public String getsTenKyNang() {
		return sTenKyNang;
	}
	public void setsTenKyNang(String sTenKyNang) {
		this.sTenKyNang = sTenKyNang;
	}
	public String getsLoaiKyNag() {
		return sLoaiKyNang;
	}
	public void setsLoaiKyNag(String sLoaiKyNang) {
		this.sLoaiKyNang = sLoaiKyNang;
	}
	public String getsMieuTa() {
		return sMieuTa;
	}
	public void setsMieuTa(String sMieuTa) {
		this.sMieuTa = sMieuTa;
	}
	public KyNang()
	{
		this.sTenKyNang="";
		this.sLoaiKyNang="";
		this.sMieuTa="";
	}
	public KyNang(String tenkn, String loaikn, String mieuta)
	{
		this.sTenKyNang=tenkn;
		this.sLoaiKyNang=loaikn;
		this.sMieuTa=mieuta;
	}
	@SuppressWarnings("resource")
	public void Nhap() throws IOException
	{
		System.out.println("Nhap ten ky nang: ");
		InputStreamReader tenkn=new InputStreamReader(System.in);
		BufferedReader tkn=new BufferedReader(tenkn);
		this.sTenKyNang=tkn.readLine();
		System.out.println("Nhap a: ");
		//BufferedReader in = null;
		int a;		
		Scanner input=new Scanner(System.in);
		do {
			System.out.println("Nhap loai ky nang: \n1. CHU DONG.\n2. BI DONG.\n");
			a=input.nextInt();
		} while (a!=1 && a!=2);
		if (a==1)
			this.sLoaiKyNang="Chu dong.";
		else this.sLoaiKyNang="Bi dong.";
		System.out.println("Mieu ta: ");
		InputStreamReader mta=new InputStreamReader(System.in);
		BufferedReader mt=new BufferedReader(mta);
		this.sMieuTa=mt.readLine();
	}
	public void Nhap(String tenkn, int loaikn, String mieuta)
	{
		this.sTenKyNang=tenkn;
		if(loaikn==2)
			this.sLoaiKyNang="Bi dong.";
		else this.sLoaiKyNang="Chu dong.";
		this.sMieuTa=mieuta;
	}
	public void Xuat()
	{
		System.out.println("- Ten ky nang: "+this.sTenKyNang);
		System.out.println("- Loai ky nang: "+this.sLoaiKyNang);
		System.out.println("- Mieu ta: "+this.sMieuTa);
	}
	public void DocFile()
	{
		//String line="";//
		BufferedReader br=null;
		try {
			br=new BufferedReader(new FileReader("KyNang.txt"));
			System.out.println("Noi dung file: ");
			String line;
			while ((line=br.readLine())!=null)
			{
				System.out.println(line);
				line=br.readLine();
			}
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
