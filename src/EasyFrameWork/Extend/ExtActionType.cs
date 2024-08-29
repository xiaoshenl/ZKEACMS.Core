using Easy.Constant;

namespace Easy.Extend
{
    public static class ExtActionType
    {
        public static bool HasFlag(this ActionType? actionType, ActionType flag)
        {
            if (actionType == null) return false;

            return actionType.Value.HasFlag(flag);
        }
    }
}
