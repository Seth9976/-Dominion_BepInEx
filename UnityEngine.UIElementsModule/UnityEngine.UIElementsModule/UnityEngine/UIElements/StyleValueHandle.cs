using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C3 RID: 195
	[Serializable]
	[StructLayout(2)]
	public struct StyleValueHandle
	{
		// Token: 0x06000B48 RID: 2888 RVA: 0x0002F3B4 File Offset: 0x0002D5B4
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValueHandle()
		{
			Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleValueHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr);
			StyleValueHandle.NativeFieldInfoPtr_m_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr, "m_ValueType");
			StyleValueHandle.NativeFieldInfoPtr_valueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr, "valueIndex");
			StyleValueHandle.NativeMethodInfoPtr_get_valueType_Public_get_StyleValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr, 100664261);
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0002F420 File Offset: 0x0002D620
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x0000713F File Offset: 0x0000533F
		public unsafe StyleValueType valueType
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueHandle.NativeMethodInfoPtr_get_valueType_Public_get_StyleValueType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_ValueType = value;
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0000712D File Offset: 0x0000532D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr_m_ValueType;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_valueIndex;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_get_valueType_Public_get_StyleValueType_0;

		// Token: 0x04000606 RID: 1542
		[FieldOffset(0)]
		public StyleValueType m_ValueType;

		// Token: 0x04000607 RID: 1543
		[FieldOffset(4)]
		public int valueIndex;
	}
}
