namespace Application.basic_logic
{
    public class ArrayOperations
    {

        /**
        * Criar um array de tamanho 'size' e retornar o array
        * Return: o array criado
        */
        public static int[] CreateArray(int size)
        {
            return new int[0];
        }

        /**
         * Criar um array de tamanho 'size', e adicionar em cada posi��o um valor sequencial, come�ando de 0
         * Return: o array criado
         */
        public static int[] CreateArrayWithSequencial(int size)
        {
            var arr = new int[size];
            for (var i=0; i < size; i++){
                arr[i] = i;
            }
            return arr;
        }

        /**
         * Ler o array passado e retornar o valor na posi��o 'pos'
         * Return: O valor na posi��o 'pos' do array criado
         */
        public static int ReturnArrayPos(int[] arr, int pos)
        {
            return arr[pos];
        }

        /**
         * Recebe dois arrays 'arr1' e 'arr2', e combina os dois. 
         * A ordem deve ser respeitada, combinando arr1 + arr2. As posi��es tamb�m devem seguir as ordens originais
         * Return: o array combinado
         */
        public static string[] JoinArrays(string[] arr1, string[] arr2)
        {
            return arr1;
        }
    }
}