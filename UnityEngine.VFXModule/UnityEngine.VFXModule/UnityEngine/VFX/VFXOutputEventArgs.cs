using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX
{
	// Token: 0x02000009 RID: 9
	public sealed class VFXOutputEventArgs : ValueType
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00004344 File Offset: 0x00002544
		// Note: this type is marked as 'beforefieldinit'.
		static VFXOutputEventArgs()
		{
			Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXOutputEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr);
			VFXOutputEventArgs.NativeFieldInfoPtr__nameId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, "<nameId>k__BackingField");
			VFXOutputEventArgs.NativeFieldInfoPtr__eventAttribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, "<eventAttribute>k__BackingField");
			VFXOutputEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, 100663321);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000043B0 File Offset: 0x000025B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21515, RefRangeEnd = 21516, XrefRangeStart = 21515, XrefRangeEnd = 21516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventAttribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXOutputEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_VFXEventAttribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002757 File Offset: 0x00000957
		public VFXOutputEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002760 File Offset: 0x00000960
		public VFXOutputEventArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr))
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00004410 File Offset: 0x00002610
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002772 File Offset: 0x00000972
		public unsafe int _nameId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXOutputEventArgs.NativeFieldInfoPtr__nameId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXOutputEventArgs.NativeFieldInfoPtr__nameId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00004438 File Offset: 0x00002638
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000278D File Offset: 0x0000098D
		public unsafe VFXEventAttribute _eventAttribute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXOutputEventArgs.NativeFieldInfoPtr__eventAttribute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXOutputEventArgs.NativeFieldInfoPtr__eventAttribute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000027AC File Offset: 0x000009AC
		public int nameId
		{
			get
			{
				return this._nameId_k__BackingField;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000027B4 File Offset: 0x000009B4
		public VFXEventAttribute eventAttribute
		{
			get
			{
				return this._eventAttribute_k__BackingField;
			}
		}

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr__nameId_k__BackingField;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr__eventAttribute_k__BackingField;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_VFXEventAttribute_0;
	}
}
