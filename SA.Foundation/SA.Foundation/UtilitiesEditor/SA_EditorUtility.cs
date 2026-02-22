using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace SA.Foundation.UtilitiesEditor
{
	// Token: 0x02000011 RID: 17
	public static class SA_EditorUtility : global::Il2CppSystem.Object
	{
		// Token: 0x06000069 RID: 105 RVA: 0x000055C0 File Offset: 0x000037C0
		// Note: this type is marked as 'beforefieldinit'.
		static SA_EditorUtility()
		{
			Il2CppClassPointerStore<SA_EditorUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.UtilitiesEditor", "SA_EditorUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_EditorUtility>.NativeClassPtr);
			SA_EditorUtility.NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorUtility>.NativeClassPtr, 100663374);
			SA_EditorUtility.NativeMethodInfoPtr_OpenScript_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorUtility>.NativeClassPtr, 100663375);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005618 File Offset: 0x00003818
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDirty(global::UnityEngine.Object target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorUtility.NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005650 File Offset: 0x00003850
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenScript(string pathToScript, int lineNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathToScript);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorUtility.NativeMethodInfoPtr_OpenScript_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002195 File Offset: 0x00000395
		public SA_EditorUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Public_Static_Void_Object_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_OpenScript_Public_Static_Void_String_Int32_0;
	}
}
