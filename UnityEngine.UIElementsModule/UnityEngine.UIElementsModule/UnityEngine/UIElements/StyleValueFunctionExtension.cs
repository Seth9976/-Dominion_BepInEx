using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C2 RID: 194
	public static class StyleValueFunctionExtension : Object
	{
		// Token: 0x06000B44 RID: 2884 RVA: 0x000070EB File Offset: 0x000052EB
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValueFunctionExtension()
		{
			Il2CppClassPointerStore<StyleValueFunctionExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleValueFunctionExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValueFunctionExtension>.NativeClassPtr);
			StyleValueFunctionExtension.NativeMethodInfoPtr_ToUssString_Public_Static_String_StyleValueFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueFunctionExtension>.NativeClassPtr, 100664260);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0002F318 File Offset: 0x0002D518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97199, XrefRangeEnd = 97203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToUssString(this StyleValueFunction svf)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref svf;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueFunctionExtension.NativeMethodInfoPtr_ToUssString_Public_Static_String_StyleValueFunction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00007124 File Offset: 0x00005324
		public StyleValueFunctionExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0002F350 File Offset: 0x0002D550
		public static StyleValueFunction FromUssString(string ussValue)
		{
			ussValue = ussValue.ToLower();
			string text = ussValue;
			string text2 = text;
			if (text2 != null)
			{
				StyleValueFunction styleValueFunction;
				if (!(text2 == "var"))
				{
					if (!(text2 == "env"))
					{
						if (!(text2 == "linear-gradient"))
						{
							goto IL_0045;
						}
						styleValueFunction = StyleValueFunction.LinearGradient;
					}
					else
					{
						styleValueFunction = StyleValueFunction.Env;
					}
				}
				else
				{
					styleValueFunction = StyleValueFunction.Var;
				}
				return styleValueFunction;
			}
			IL_0045:
			throw new ArgumentOutOfRangeException("ussValue", ussValue, "Unknown function name");
		}

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_ToUssString_Public_Static_String_StyleValueFunction_0;

		// Token: 0x04000600 RID: 1536
		public const string k_Var = "var";

		// Token: 0x04000601 RID: 1537
		public const string k_Env = "env";

		// Token: 0x04000602 RID: 1538
		public const string k_LinearGradient = "linear-gradient";
	}
}
