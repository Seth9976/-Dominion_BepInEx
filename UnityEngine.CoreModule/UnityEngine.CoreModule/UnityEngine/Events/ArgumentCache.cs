using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x020000FA RID: 250
	[Serializable]
	public class ArgumentCache : Object
	{
		// Token: 0x0600153C RID: 5436 RVA: 0x00050B14 File Offset: 0x0004ED14
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentCache()
		{
			Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "ArgumentCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr);
			ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_ObjectArgument");
			ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_ObjectArgumentAssemblyTypeName");
			ArgumentCache.NativeFieldInfoPtr_m_IntArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_IntArgument");
			ArgumentCache.NativeFieldInfoPtr_m_FloatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_FloatArgument");
			ArgumentCache.NativeFieldInfoPtr_m_StringArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_StringArgument");
			ArgumentCache.NativeFieldInfoPtr_m_BoolArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_BoolArgument");
			ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100664848);
			ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100664849);
			ArgumentCache.NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100664850);
			ArgumentCache.NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100664851);
			ArgumentCache.NativeMethodInfoPtr_get_stringArgument_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100664852);
			ArgumentCache.NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100664853);
			ArgumentCache.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100664854);
			ArgumentCache.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100664855);
			ArgumentCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100664856);
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x00050C70 File Offset: 0x0004EE70
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x0000C3D1 File Offset: 0x0000A5D1
		public unsafe Object unityObjectArgument
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58951, XrefRangeStart = 58949, XrefRangeEnd = 58951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			set
			{
				this.m_ObjectArgument = value;
				this.m_ObjectArgumentAssemblyTypeName = ((value != null) ? value.GetType().AssemblyQualifiedName : String.Empty);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x00050CB0 File Offset: 0x0004EEB0
		public unsafe string unityObjectArgumentAssemblyTypeName
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79925, RefRangeEnd = 79936, XrefRangeStart = 79925, XrefRangeEnd = 79925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x00050CE8 File Offset: 0x0004EEE8
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		public unsafe int intArgument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_IntArgument = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00050D24 File Offset: 0x0004EF24
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x0000C406 File Offset: 0x0000A606
		public unsafe float floatArgument
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 79936, RefRangeEnd = 79952, XrefRangeStart = 79936, XrefRangeEnd = 79936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FloatArgument = value;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00050D60 File Offset: 0x0004EF60
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x0000C410 File Offset: 0x0000A610
		public unsafe string stringArgument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_stringArgument_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_StringArgument = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00050D98 File Offset: 0x0004EF98
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x0000C41A File Offset: 0x0000A61A
		public unsafe bool boolArgument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoolArgument = value;
			}
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00050DD4 File Offset: 0x0004EFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79952, XrefRangeEnd = 79953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00050E08 File Offset: 0x0004F008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00050E3C File Offset: 0x0004F03C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0000C31A File Offset: 0x0000A51A
		public ArgumentCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x00050E78 File Offset: 0x0004F078
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x0000C323 File Offset: 0x0000A523
		public unsafe Object m_ObjectArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00050EA8 File Offset: 0x0004F0A8
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x0000C342 File Offset: 0x0000A542
		public unsafe string m_ObjectArgumentAssemblyTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x00050ED0 File Offset: 0x0004F0D0
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x0000C361 File Offset: 0x0000A561
		public unsafe int m_IntArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_IntArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_IntArgument)) = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x00050EF8 File Offset: 0x0004F0F8
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x0000C37C File Offset: 0x0000A57C
		public unsafe float m_FloatArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_FloatArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_FloatArgument)) = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x00050F20 File Offset: 0x0004F120
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x0000C397 File Offset: 0x0000A597
		public unsafe string m_StringArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_StringArgument);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_StringArgument), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x00050F48 File Offset: 0x0004F148
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x0000C3B6 File Offset: 0x0000A5B6
		public unsafe bool m_BoolArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_BoolArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_BoolArgument)) = value;
			}
		}

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectArgument;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeFieldInfoPtr_m_IntArgument;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeFieldInfoPtr_m_FloatArgument;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeFieldInfoPtr_m_StringArgument;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeFieldInfoPtr_m_BoolArgument;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_get_stringArgument_Public_get_String_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
