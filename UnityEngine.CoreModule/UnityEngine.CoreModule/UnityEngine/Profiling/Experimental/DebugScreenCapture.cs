using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Profiling.Experimental
{
	// Token: 0x020000E8 RID: 232
	public sealed class DebugScreenCapture : ValueType
	{
		// Token: 0x0600144C RID: 5196 RVA: 0x0004E4F4 File Offset: 0x0004C6F4
		// Note: this type is marked as 'beforefieldinit'.
		static DebugScreenCapture()
		{
			Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling.Experimental", "DebugScreenCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr);
			DebugScreenCapture.NativeFieldInfoPtr__rawImageDataReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<rawImageDataReference>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__imageFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<imageFormat>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<width>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<height>k__BackingField");
			DebugScreenCapture.NativeMethodInfoPtr_set_rawImageDataReference_Public_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100664758);
			DebugScreenCapture.NativeMethodInfoPtr_set_imageFormat_Public_set_Void_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100664759);
			DebugScreenCapture.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100664760);
			DebugScreenCapture.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100664761);
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0000BB9B File Offset: 0x00009D9B
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x0004E5C4 File Offset: 0x0004C7C4
		public unsafe Unity.Collections.NativeArray<byte> rawImageDataReference
		{
			get
			{
				return this._rawImageDataReference_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_rawImageDataReference_Public_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0000BBA3 File Offset: 0x00009DA3
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x0004E610 File Offset: 0x0004C810
		public unsafe TextureFormat imageFormat
		{
			get
			{
				return this._imageFormat_k__BackingField;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_imageFormat_Public_set_Void_TextureFormat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0000BBAB File Offset: 0x00009DAB
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x0004E654 File Offset: 0x0004C854
		public unsafe int width
		{
			get
			{
				return this._width_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0000BBB3 File Offset: 0x00009DB3
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x0004E698 File Offset: 0x0004C898
		public unsafe int height
		{
			get
			{
				return this._height_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0000BB01 File Offset: 0x00009D01
		public DebugScreenCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0000BB0A File Offset: 0x00009D0A
		public DebugScreenCapture()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr))
		{
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0004E6DC File Offset: 0x0004C8DC
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x0000BB1C File Offset: 0x00009D1C
		public Unity.Collections.NativeArray<byte> _rawImageDataReference_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__rawImageDataReference_k__BackingField);
				return new Unity.Collections.NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__rawImageDataReference_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x0004E70C File Offset: 0x0004C90C
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x0000BB4A File Offset: 0x00009D4A
		public unsafe TextureFormat _imageFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__imageFormat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__imageFormat_k__BackingField)) = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0004E734 File Offset: 0x0004C934
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x0000BB65 File Offset: 0x00009D65
		public unsafe int _width_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__width_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__width_k__BackingField)) = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0004E75C File Offset: 0x0004C95C
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x0000BB80 File Offset: 0x00009D80
		public unsafe int _height_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__height_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__height_k__BackingField)) = value;
			}
		}

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeFieldInfoPtr__rawImageDataReference_k__BackingField;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeFieldInfoPtr__imageFormat_k__BackingField;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeFieldInfoPtr__width_k__BackingField;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr__height_k__BackingField;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_set_rawImageDataReference_Public_set_Void_NativeArray_1_Byte_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_set_imageFormat_Public_set_Void_TextureFormat_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;
	}
}
