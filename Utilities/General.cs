namespace InvativaNet.Core.Utilities {
    using ServiceStack.Text;

    public class General {
        public static string JsonSerialize(object source) {
            return JsonSerializer.SerializeToString(source);
        }
    }
}
