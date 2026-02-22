using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200000F RID: 15
	[StructLayout(2)]
	public struct FontEngineUtilities
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0000279A File Offset: 0x0000099A
		// Note: this type is marked as 'beforefieldinit'.
		static FontEngineUtilities()
		{
			Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreModule.dll", "UnityEngine.TextCore.LowLevel", "FontEngineUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr);
			FontEngineUtilities.NativeMethodInfoPtr_MaxValue_Internal_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr, 100663398);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00006C78 File Offset: 0x00004E78
		[CallerCount(0)]
		public unsafe static int MaxValue(int a, int b, int c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngineUtilities.NativeMethodInfoPtr_MaxValue_Internal_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000027D3 File Offset: 0x000009D3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr, ref this));
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006CD4 File Offset: 0x00004ED4
		public static bool Approximately(float a, float b)
		{
			return Mathf.Abs(a - b) < 0.001f;
		}

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_MaxValue_Internal_Static_Int32_Int32_Int32_Int32_0;
	}
}
