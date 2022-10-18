using System;
namespace Polynomial
{
	public class Polynomial
	{

		private LinkedList<Term> terms;

		public int NumberOfTerms => terms.Count;

		public int Degree => NumberOfTerms == 0 ? 0 : terms.First.Value.Power;

		public Polynomial()
		{
			terms = new LinkedList<Term>();

		}

		//TODO
		public void AddTerm(double coeff, int power)
		{
            var currentNode = terms.First;
            while(currentNode != null)
            {
                //check for matching power
                if (power == currentNode.Value.Power)
                {
                    currentNode.Value.Coefficient += coeff;
                    return;
                }
                //Check for lesser power
                if (power > currentNode.Value.Power)
                {
                    var newTerm = new Term(power, coeff);

                    terms.AddBefore(currentNode, newTerm);
                    return;
                }

                currentNode = currentNode.Next;
            }
            terms.AddLast(new Term(power, coeff));
		}

        //TODO
        public override string ToString()
        {
            string result = "";
            foreach(var term in terms)
            {
                result += term.ToString();
            }

            return result;
        }

		public static Polynomial Add(Polynomial p1, Polynomial p2)
        {
			Polynomial sum = new Polynomial();

            //Add all the terms from p1 to Sum
            foreach(var term in p1.terms)
            {
                sum.AddTerm(term.Coefficient, term.Power);
            }

            //Add all the terms from p2 to Sum
            foreach(var term in p2.terms)
            {
                sum.AddTerm(term.Coefficient, term.Power);
            }

            return sum;
        }
        public static Polynomial Subtract(Polynomial p1, Polynomial p2)
        {
            Polynomial difference = new Polynomial();
            //Do the work...

            return difference;
        }
        public static Polynomial Negate(Polynomial p1, Polynomial p2)
        {
            Polynomial inverse = new Polynomial();

            foreach (var term in p2.terms)
            {
                inverse.AddTerm(term.Coefficient * -1, term.Power);
            }

            return inverse;
        }
        public static Polynomial Multiply(Polynomial p1, Polynomial p2)
        {
            Polynomial sum = new Polynomial();
            //Do the work...

            return ;
        }
    }
}

