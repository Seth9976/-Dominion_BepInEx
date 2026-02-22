using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B5 RID: 181
	public static class StyleValueExtensions : Object
	{
		// Token: 0x06000A0C RID: 2572 RVA: 0x000064BA File Offset: 0x000046BA
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValueExtensions()
		{
			Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleValueExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr);
			StyleValueExtensions.NativeMethodInfoPtr_DebugString_Internal_Static_String_IStyleValue_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr, 100664189);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0002BFD4 File Offset: 0x0002A1D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96730, RefRangeEnd = 96731, XrefRangeStart = 96716, XrefRangeEnd = 96730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DebugString<T>(this IStyleValue<T> styleValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(styleValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueExtensions.MethodInfoStoreGeneric_DebugString_Internal_Static_String_IStyleValue_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000064F3 File Offset: 0x000046F3
		public StyleValueExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0002C010 File Offset: 0x0002A210
		public static Length ToLength(StyleKeyword keyword)
		{
			StyleKeyword styleKeyword = keyword;
			StyleKeyword styleKeyword2 = styleKeyword;
			Length length;
			if (styleKeyword2 != StyleKeyword.Auto)
			{
				if (styleKeyword2 != StyleKeyword.None)
				{
					Debug.LogAssertion(String.Concat("Unexpected StyleKeyword '", keyword.ToString(), "'"));
					length = default(Length);
				}
				else
				{
					length = Length.None();
				}
			}
			else
			{
				length = Length.Auto();
			}
			return length;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0002C070 File Offset: 0x0002A270
		public static Length ToLength(StyleLength styleLength)
		{
			StyleKeyword keyword = styleLength.keyword;
			StyleKeyword styleKeyword = keyword;
			Length length;
			if (styleKeyword - StyleKeyword.Auto > 1)
			{
				length = styleLength.value;
			}
			else
			{
				length = StyleValueExtensions.ToLength(styleLength.keyword);
			}
			return length;
		}

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_DebugString_Internal_Static_String_IStyleValue_1_T_0;

		// Token: 0x02000220 RID: 544
		private sealed class MethodInfoStoreGeneric_DebugString_Internal_Static_String_IStyleValue_1_T_0<T>
		{
			// Token: 0x040008DB RID: 2267
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StyleValueExtensions.NativeMethodInfoPtr_DebugString_Internal_Static_String_IStyleValue_1_T_0, Il2CppClassPointerStore<StyleValueExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
