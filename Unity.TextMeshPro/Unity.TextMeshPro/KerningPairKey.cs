using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000033 RID: 51
	[StructLayout(2)]
	public struct KerningPairKey
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x0001B968 File Offset: 0x00019B68
		// Note: this type is marked as 'beforefieldinit'.
		static KerningPairKey()
		{
			Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "KerningPairKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr);
			KerningPairKey.NativeFieldInfoPtr_ascii_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, "ascii_Left");
			KerningPairKey.NativeFieldInfoPtr_ascii_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, "ascii_Right");
			KerningPairKey.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, "key");
			KerningPairKey.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, 100663811);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001B9E8 File Offset: 0x00019BE8
		[CallerCount(0)]
		public unsafe KerningPairKey(uint ascii_left, uint ascii_right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ascii_left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ascii_right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningPairKey.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00004CEE File Offset: 0x00002EEE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KerningPairKey>.NativeClassPtr, ref this));
		}

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_ascii_Left;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_ascii_Right;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

		// Token: 0x040003F9 RID: 1017
		[FieldOffset(0)]
		public uint ascii_Left;

		// Token: 0x040003FA RID: 1018
		[FieldOffset(4)]
		public uint ascii_Right;

		// Token: 0x040003FB RID: 1019
		[FieldOffset(8)]
		public uint key;
	}
}
