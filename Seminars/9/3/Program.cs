/*/ рекурсия стрингом
*/
using System.Text;

StringBuilder GetNumbers(int i, StringBuilder sb = null)
{
	if (sb is null)
	{
		sb = new StringBuilder();
	}

	if (i == 1)
	{
		sb.Append(i.ToString() + " ");
		return sb;
	}

	GetNumbers(i - 1, sb);
	sb.Append(i.ToString() + " ");

	return sb;
}

Console.WriteLine(GetNumbers(5).ToString());
