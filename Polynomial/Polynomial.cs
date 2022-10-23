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
            if (coeff == 0)
            {
                return;
            }
            var currentNode = terms.First;
            while (currentNode != null)
            {
                if (power == currentNode.Value.Power)
                {
                    currentNode.Value.Coefficient += coeff;
                    return;
                }

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
            if (NumberOfTerms == 0)
            {
                return "0";
            }

            foreach (var term in terms)
            {
                result += term.ToString();

                if (term != terms.Last.Value)
                {
                    result += "+";
                }
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
            // subtract all the terms from p1
            foreach (var term in p1.terms)
            {
                difference.AddTerm(term.Coefficient, term.Power);
            }
            // subtract all the terms from p2
            foreach (var term in p2.terms)
            {
                difference.AddTerm(term.Coefficient, term.Power);
            }

            return difference;
        }
        public static Polynomial Negate(Polynomial p)
        {
            Polynomial inverse = new Polynomial();
            foreach (var term in p.terms)
            {
                inverse.AddTerm(term.Coefficient * -1, term.Power);
                return inverse;

            }

            return inverse;
        }

        public static Polynomial Multiply(Polynomial p1, Polynomial p2)
        {
            Polynomial product = new Polynomial();
            while (p1 != null)
            {
                p2 = p2;
                while (p2 != null)
                {

                }
            }
            return product;
        }


    }
}

