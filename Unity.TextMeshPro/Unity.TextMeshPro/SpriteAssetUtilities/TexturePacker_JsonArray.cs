using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro.SpriteAssetUtilities
{
	// Token: 0x02000074 RID: 116
	public class TexturePacker_JsonArray : global::Il2CppSystem.Object
	{
		// Token: 0x06000E78 RID: 3704 RVA: 0x00008CBD File Offset: 0x00006EBD
		// Note: this type is marked as 'beforefieldinit'.
		static TexturePacker_JsonArray()
		{
			Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro.SpriteAssetUtilities", "TexturePacker_JsonArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr);
			TexturePacker_JsonArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, 100664784);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0003A9A4 File Offset: 0x00038BA4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TexturePacker_JsonArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePacker_JsonArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00008CF6 File Offset: 0x00006EF6
		public TexturePacker_JsonArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B2 RID: 178
		[Serializable]
		[StructLayout(2)]
		public struct SpriteFrame
		{
			// Token: 0x0600101A RID: 4122 RVA: 0x0003F4FC File Offset: 0x0003D6FC
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteFrame()
			{
				Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, "SpriteFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr);
				TexturePacker_JsonArray.SpriteFrame.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, "x");
				TexturePacker_JsonArray.SpriteFrame.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, "y");
				TexturePacker_JsonArray.SpriteFrame.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, "w");
				TexturePacker_JsonArray.SpriteFrame.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, "h");
				TexturePacker_JsonArray.SpriteFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, 100664912);
			}

			// Token: 0x0600101B RID: 4123 RVA: 0x0003F58C File Offset: 0x0003D78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149897, XrefRangeEnd = 149963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePacker_JsonArray.SpriteFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600101C RID: 4124 RVA: 0x00009B14 File Offset: 0x00007D14
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, ref this));
			}

			// Token: 0x04000CA1 RID: 3233
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04000CA2 RID: 3234
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04000CA3 RID: 3235
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x04000CA4 RID: 3236
			private static readonly IntPtr NativeFieldInfoPtr_h;

			// Token: 0x04000CA5 RID: 3237
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04000CA6 RID: 3238
			[FieldOffset(0)]
			public float x;

			// Token: 0x04000CA7 RID: 3239
			[FieldOffset(4)]
			public float y;

			// Token: 0x04000CA8 RID: 3240
			[FieldOffset(8)]
			public float w;

			// Token: 0x04000CA9 RID: 3241
			[FieldOffset(12)]
			public float h;
		}

		// Token: 0x020000B3 RID: 179
		[Serializable]
		[StructLayout(2)]
		public struct SpriteSize
		{
			// Token: 0x0600101D RID: 4125 RVA: 0x0003F5B8 File Offset: 0x0003D7B8
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteSize()
			{
				Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, "SpriteSize");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr);
				TexturePacker_JsonArray.SpriteSize.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr, "w");
				TexturePacker_JsonArray.SpriteSize.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr, "h");
				TexturePacker_JsonArray.SpriteSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr, 100664913);
			}

			// Token: 0x0600101E RID: 4126 RVA: 0x0003F620 File Offset: 0x0003D820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149963, XrefRangeEnd = 149973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePacker_JsonArray.SpriteSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600101F RID: 4127 RVA: 0x00009B26 File Offset: 0x00007D26
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr, ref this));
			}

			// Token: 0x04000CAA RID: 3242
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x04000CAB RID: 3243
			private static readonly IntPtr NativeFieldInfoPtr_h;

			// Token: 0x04000CAC RID: 3244
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04000CAD RID: 3245
			[FieldOffset(0)]
			public float w;

			// Token: 0x04000CAE RID: 3246
			[FieldOffset(4)]
			public float h;
		}

		// Token: 0x020000B4 RID: 180
		[Serializable]
		public sealed class Frame : ValueType
		{
			// Token: 0x06001020 RID: 4128 RVA: 0x0003F64C File Offset: 0x0003D84C
			// Note: this type is marked as 'beforefieldinit'.
			static Frame()
			{
				Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, "Frame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr);
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "filename");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "frame");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_rotated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "rotated");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_trimmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "trimmed");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_spriteSourceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "spriteSourceSize");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_sourceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "sourceSize");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "pivot");
			}

			// Token: 0x06001021 RID: 4129 RVA: 0x00009B38 File Offset: 0x00007D38
			public Frame(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001022 RID: 4130 RVA: 0x00009B41 File Offset: 0x00007D41
			public Frame()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr))
			{
			}

			// Token: 0x170005D3 RID: 1491
			// (get) Token: 0x06001023 RID: 4131 RVA: 0x0003F704 File Offset: 0x0003D904
			// (set) Token: 0x06001024 RID: 4132 RVA: 0x00009B53 File Offset: 0x00007D53
			public unsafe string filename
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_filename);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_filename), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005D4 RID: 1492
			// (get) Token: 0x06001025 RID: 4133 RVA: 0x0003F72C File Offset: 0x0003D92C
			// (set) Token: 0x06001026 RID: 4134 RVA: 0x00009B72 File Offset: 0x00007D72
			public unsafe TexturePacker_JsonArray.SpriteFrame frame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_frame);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_frame)) = value;
				}
			}

			// Token: 0x170005D5 RID: 1493
			// (get) Token: 0x06001027 RID: 4135 RVA: 0x0003F754 File Offset: 0x0003D954
			// (set) Token: 0x06001028 RID: 4136 RVA: 0x00009B8D File Offset: 0x00007D8D
			public unsafe bool rotated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_rotated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_rotated)) = value;
				}
			}

			// Token: 0x170005D6 RID: 1494
			// (get) Token: 0x06001029 RID: 4137 RVA: 0x0003F77C File Offset: 0x0003D97C
			// (set) Token: 0x0600102A RID: 4138 RVA: 0x00009BA8 File Offset: 0x00007DA8
			public unsafe bool trimmed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_trimmed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_trimmed)) = value;
				}
			}

			// Token: 0x170005D7 RID: 1495
			// (get) Token: 0x0600102B RID: 4139 RVA: 0x0003F7A4 File Offset: 0x0003D9A4
			// (set) Token: 0x0600102C RID: 4140 RVA: 0x00009BC3 File Offset: 0x00007DC3
			public unsafe TexturePacker_JsonArray.SpriteFrame spriteSourceSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_spriteSourceSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_spriteSourceSize)) = value;
				}
			}

			// Token: 0x170005D8 RID: 1496
			// (get) Token: 0x0600102D RID: 4141 RVA: 0x0003F7CC File Offset: 0x0003D9CC
			// (set) Token: 0x0600102E RID: 4142 RVA: 0x00009BDE File Offset: 0x00007DDE
			public unsafe TexturePacker_JsonArray.SpriteSize sourceSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_sourceSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_sourceSize)) = value;
				}
			}

			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x0600102F RID: 4143 RVA: 0x0003F7F4 File Offset: 0x0003D9F4
			// (set) Token: 0x06001030 RID: 4144 RVA: 0x00009BF9 File Offset: 0x00007DF9
			public unsafe Vector2 pivot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_pivot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_pivot)) = value;
				}
			}

			// Token: 0x04000CAF RID: 3247
			private static readonly IntPtr NativeFieldInfoPtr_filename;

			// Token: 0x04000CB0 RID: 3248
			private static readonly IntPtr NativeFieldInfoPtr_frame;

			// Token: 0x04000CB1 RID: 3249
			private static readonly IntPtr NativeFieldInfoPtr_rotated;

			// Token: 0x04000CB2 RID: 3250
			private static readonly IntPtr NativeFieldInfoPtr_trimmed;

			// Token: 0x04000CB3 RID: 3251
			private static readonly IntPtr NativeFieldInfoPtr_spriteSourceSize;

			// Token: 0x04000CB4 RID: 3252
			private static readonly IntPtr NativeFieldInfoPtr_sourceSize;

			// Token: 0x04000CB5 RID: 3253
			private static readonly IntPtr NativeFieldInfoPtr_pivot;
		}

		// Token: 0x020000B5 RID: 181
		[Serializable]
		public sealed class Meta : ValueType
		{
			// Token: 0x06001031 RID: 4145 RVA: 0x0003F81C File Offset: 0x0003DA1C
			// Note: this type is marked as 'beforefieldinit'.
			static Meta()
			{
				Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, "Meta");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr);
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_app = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "app");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "version");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "image");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "format");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "size");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "scale");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_smartupdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "smartupdate");
			}

			// Token: 0x06001032 RID: 4146 RVA: 0x00009C14 File Offset: 0x00007E14
			public Meta(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001033 RID: 4147 RVA: 0x00009C1D File Offset: 0x00007E1D
			public Meta()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr))
			{
			}

			// Token: 0x170005DA RID: 1498
			// (get) Token: 0x06001034 RID: 4148 RVA: 0x0003F8D4 File Offset: 0x0003DAD4
			// (set) Token: 0x06001035 RID: 4149 RVA: 0x00009C2F File Offset: 0x00007E2F
			public unsafe string app
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_app);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_app), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005DB RID: 1499
			// (get) Token: 0x06001036 RID: 4150 RVA: 0x0003F8FC File Offset: 0x0003DAFC
			// (set) Token: 0x06001037 RID: 4151 RVA: 0x00009C4E File Offset: 0x00007E4E
			public unsafe string version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_version);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_version), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005DC RID: 1500
			// (get) Token: 0x06001038 RID: 4152 RVA: 0x0003F924 File Offset: 0x0003DB24
			// (set) Token: 0x06001039 RID: 4153 RVA: 0x00009C6D File Offset: 0x00007E6D
			public unsafe string image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_image);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_image), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005DD RID: 1501
			// (get) Token: 0x0600103A RID: 4154 RVA: 0x0003F94C File Offset: 0x0003DB4C
			// (set) Token: 0x0600103B RID: 4155 RVA: 0x00009C8C File Offset: 0x00007E8C
			public unsafe string format
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_format);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005DE RID: 1502
			// (get) Token: 0x0600103C RID: 4156 RVA: 0x0003F974 File Offset: 0x0003DB74
			// (set) Token: 0x0600103D RID: 4157 RVA: 0x00009CAB File Offset: 0x00007EAB
			public unsafe TexturePacker_JsonArray.SpriteSize size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x170005DF RID: 1503
			// (get) Token: 0x0600103E RID: 4158 RVA: 0x0003F99C File Offset: 0x0003DB9C
			// (set) Token: 0x0600103F RID: 4159 RVA: 0x00009CC6 File Offset: 0x00007EC6
			public unsafe float scale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_scale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_scale)) = value;
				}
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x06001040 RID: 4160 RVA: 0x0003F9C4 File Offset: 0x0003DBC4
			// (set) Token: 0x06001041 RID: 4161 RVA: 0x00009CE1 File Offset: 0x00007EE1
			public unsafe string smartupdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_smartupdate);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_smartupdate), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000CB6 RID: 3254
			private static readonly IntPtr NativeFieldInfoPtr_app;

			// Token: 0x04000CB7 RID: 3255
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04000CB8 RID: 3256
			private static readonly IntPtr NativeFieldInfoPtr_image;

			// Token: 0x04000CB9 RID: 3257
			private static readonly IntPtr NativeFieldInfoPtr_format;

			// Token: 0x04000CBA RID: 3258
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04000CBB RID: 3259
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x04000CBC RID: 3260
			private static readonly IntPtr NativeFieldInfoPtr_smartupdate;
		}

		// Token: 0x020000B6 RID: 182
		[Serializable]
		public class SpriteDataObject : global::Il2CppSystem.Object
		{
			// Token: 0x06001042 RID: 4162 RVA: 0x0003F9EC File Offset: 0x0003DBEC
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteDataObject()
			{
				Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, "SpriteDataObject");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr);
				TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr, "frames");
				TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_meta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr, "meta");
				TexturePacker_JsonArray.SpriteDataObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr, 100664914);
			}

			// Token: 0x06001043 RID: 4163 RVA: 0x0003FA54 File Offset: 0x0003DC54
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpriteDataObject()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePacker_JsonArray.SpriteDataObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001044 RID: 4164 RVA: 0x00009D00 File Offset: 0x00007F00
			public SpriteDataObject(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x06001045 RID: 4165 RVA: 0x0003FA90 File Offset: 0x0003DC90
			// (set) Token: 0x06001046 RID: 4166 RVA: 0x00009D09 File Offset: 0x00007F09
			public unsafe List<TexturePacker_JsonArray.Frame> frames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_frames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TexturePacker_JsonArray.Frame>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_frames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x06001047 RID: 4167 RVA: 0x0003FAC0 File Offset: 0x0003DCC0
			// (set) Token: 0x06001048 RID: 4168 RVA: 0x00009D28 File Offset: 0x00007F28
			public TexturePacker_JsonArray.Meta meta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_meta);
					return new TexturePacker_JsonArray.Meta(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_meta), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000CBD RID: 3261
			private static readonly IntPtr NativeFieldInfoPtr_frames;

			// Token: 0x04000CBE RID: 3262
			private static readonly IntPtr NativeFieldInfoPtr_meta;

			// Token: 0x04000CBF RID: 3263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
