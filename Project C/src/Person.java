
public class Person {
	String name;
	int age;
	String adres;
	String gender;
	public Person()	 {
		// TODO Auto-generated constructor stub
	}
	public Person(String name, int age, String adres, String gender) {
		super();
		this.name = name;
		this.age = age;
		this.adres = adres;
		this.gender = gender;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getAdres() {
		return adres;
	}
	public void setAdres(String adres) {
		this.adres = adres;
	}
	public String getGender() {
		return gender;
	}
	public void setGender(String gender) {
		this.gender = gender;
	}

}
