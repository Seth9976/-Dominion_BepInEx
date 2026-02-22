using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

namespace SA.Fitness
{
	// Token: 0x02000328 RID: 808
	public sealed class Connection : Singleton<Connection>
	{
		// Token: 0x06002F85 RID: 12165 RVA: 0x000CB05C File Offset: 0x000C925C
		// Note: this type is marked as 'beforefieldinit'.
		static Connection()
		{
			Il2CppClassPointerStore<Connection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "Connection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Connection>.NativeClassPtr);
			Connection.NativeFieldInfoPtr_SEPARATOR1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "SEPARATOR1");
			Connection.NativeFieldInfoPtr_SEPARATOR2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "SEPARATOR2");
			Connection.NativeFieldInfoPtr_SEPARATOR3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "SEPARATOR3");
			Connection.NativeFieldInfoPtr_SEPARATOR4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "SEPARATOR4");
			Connection.NativeFieldInfoPtr_SEPARATOR5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "SEPARATOR5");
			Connection.NativeFieldInfoPtr_RESULT_OK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "RESULT_OK");
			Connection.NativeFieldInfoPtr_OnConnectionFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "OnConnectionFinished");
			Connection.NativeFieldInfoPtr_apis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "apis");
			Connection.NativeFieldInfoPtr_scopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "scopes");
			Connection.NativeFieldInfoPtr_connectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "connectionState");
			Connection.NativeFieldInfoPtr_shouldManageReconnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "shouldManageReconnection");
			Connection.NativeMethodInfoPtr_add_OnConnectionFinished_Public_add_Void_Action_1_ConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669595);
			Connection.NativeMethodInfoPtr_remove_OnConnectionFinished_Public_rem_Void_Action_1_ConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669596);
			Connection.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669597);
			Connection.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669598);
			Connection.NativeMethodInfoPtr_AddApi_Public_Void_LoginApi_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669599);
			Connection.NativeMethodInfoPtr_AddScope_Public_Void_LoginScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669600);
			Connection.NativeMethodInfoPtr_Connect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669601);
			Connection.NativeMethodInfoPtr_Disconnect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669602);
			Connection.NativeMethodInfoPtr_ConnectionResultHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669603);
			Connection.NativeMethodInfoPtr_get_ConnectionState_Public_get_ConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669604);
			Connection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100669605);
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x000CB244 File Offset: 0x000C9444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220527, RefRangeEnd = 220528, XrefRangeStart = 220523, XrefRangeEnd = 220527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnConnectionFinished(Action<ConnectionResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_add_OnConnectionFinished_Public_add_Void_Action_1_ConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x000CB288 File Offset: 0x000C9488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220528, XrefRangeEnd = 220532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnConnectionFinished(Action<ConnectionResult> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_remove_OnConnectionFinished_Public_rem_Void_Action_1_ConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x000CB2CC File Offset: 0x000C94CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220532, XrefRangeEnd = 220537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x000CB300 File Offset: 0x000C9500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220537, XrefRangeEnd = 220539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationPause(bool pauseStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pauseStatus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x000CB340 File Offset: 0x000C9540
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 220545, RefRangeEnd = 220549, XrefRangeStart = 220539, XrefRangeEnd = 220545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddApi(LoginApi api)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(api);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_AddApi_Public_Void_LoginApi_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x000CB384 File Offset: 0x000C9584
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 220555, RefRangeEnd = 220563, XrefRangeStart = 220549, XrefRangeEnd = 220555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScope(LoginScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_AddScope_Public_Void_LoginScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x000CB3C8 File Offset: 0x000C95C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220592, RefRangeEnd = 220594, XrefRangeStart = 220563, XrefRangeEnd = 220592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_Connect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x000CB3FC File Offset: 0x000C95FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220594, XrefRangeEnd = 220595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_Disconnect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x000CB430 File Offset: 0x000C9630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220595, XrefRangeEnd = 220623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectionResultHandler(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_ConnectionResultHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x000CB474 File Offset: 0x000C9674
		public unsafe ConnectionState ConnectionState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_get_ConnectionState_Public_get_ConnectionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x000CB4B0 File Offset: 0x000C96B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220623, XrefRangeEnd = 220657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Connection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Connection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00012215 File Offset: 0x00010415
		public Connection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x000CB4EC File Offset: 0x000C96EC
		// (set) Token: 0x06002F93 RID: 12179 RVA: 0x0001221E File Offset: 0x0001041E
		public unsafe static string SEPARATOR1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Connection.NativeFieldInfoPtr_SEPARATOR1, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Connection.NativeFieldInfoPtr_SEPARATOR1, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002F94 RID: 12180 RVA: 0x000CB50C File Offset: 0x000C970C
		// (set) Token: 0x06002F95 RID: 12181 RVA: 0x00012230 File Offset: 0x00010430
		public unsafe static string SEPARATOR2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Connection.NativeFieldInfoPtr_SEPARATOR2, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Connection.NativeFieldInfoPtr_SEPARATOR2, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x000CB52C File Offset: 0x000C972C
		// (set) Token: 0x06002F97 RID: 12183 RVA: 0x00012242 File Offset: 0x00010442
		public unsafe static string SEPARATOR3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Connection.NativeFieldInfoPtr_SEPARATOR3, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Connection.NativeFieldInfoPtr_SEPARATOR3, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x000CB54C File Offset: 0x000C974C
		// (set) Token: 0x06002F99 RID: 12185 RVA: 0x00012254 File Offset: 0x00010454
		public unsafe static string SEPARATOR4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Connection.NativeFieldInfoPtr_SEPARATOR4, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Connection.NativeFieldInfoPtr_SEPARATOR4, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x000CB56C File Offset: 0x000C976C
		// (set) Token: 0x06002F9B RID: 12187 RVA: 0x00012266 File Offset: 0x00010466
		public unsafe static string SEPARATOR5
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Connection.NativeFieldInfoPtr_SEPARATOR5, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Connection.NativeFieldInfoPtr_SEPARATOR5, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x000CB58C File Offset: 0x000C978C
		// (set) Token: 0x06002F9D RID: 12189 RVA: 0x00012278 File Offset: 0x00010478
		public unsafe static int RESULT_OK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Connection.NativeFieldInfoPtr_RESULT_OK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Connection.NativeFieldInfoPtr_RESULT_OK, (void*)(&value));
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x000CB5A8 File Offset: 0x000C97A8
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x00012286 File Offset: 0x00010486
		public unsafe Action<ConnectionResult> OnConnectionFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Connection.NativeFieldInfoPtr_OnConnectionFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ConnectionResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Connection.NativeFieldInfoPtr_OnConnectionFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x000CB5D8 File Offset: 0x000C97D8
		// (set) Token: 0x06002FA1 RID: 12193 RVA: 0x000122A5 File Offset: 0x000104A5
		public unsafe List<LoginApi> apis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Connection.NativeFieldInfoPtr_apis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LoginApi>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Connection.NativeFieldInfoPtr_apis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x000CB608 File Offset: 0x000C9808
		// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x000122C4 File Offset: 0x000104C4
		public unsafe List<LoginScope> scopes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Connection.NativeFieldInfoPtr_scopes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LoginScope>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Connection.NativeFieldInfoPtr_scopes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x000CB638 File Offset: 0x000C9838
		// (set) Token: 0x06002FA5 RID: 12197 RVA: 0x000122E3 File Offset: 0x000104E3
		public unsafe ConnectionState connectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Connection.NativeFieldInfoPtr_connectionState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Connection.NativeFieldInfoPtr_connectionState)) = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002FA6 RID: 12198 RVA: 0x000CB660 File Offset: 0x000C9860
		// (set) Token: 0x06002FA7 RID: 12199 RVA: 0x000122FE File Offset: 0x000104FE
		public unsafe bool shouldManageReconnection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Connection.NativeFieldInfoPtr_shouldManageReconnection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Connection.NativeFieldInfoPtr_shouldManageReconnection)) = value;
			}
		}

		// Token: 0x04002D70 RID: 11632
		private static readonly IntPtr NativeFieldInfoPtr_SEPARATOR1;

		// Token: 0x04002D71 RID: 11633
		private static readonly IntPtr NativeFieldInfoPtr_SEPARATOR2;

		// Token: 0x04002D72 RID: 11634
		private static readonly IntPtr NativeFieldInfoPtr_SEPARATOR3;

		// Token: 0x04002D73 RID: 11635
		private static readonly IntPtr NativeFieldInfoPtr_SEPARATOR4;

		// Token: 0x04002D74 RID: 11636
		private static readonly IntPtr NativeFieldInfoPtr_SEPARATOR5;

		// Token: 0x04002D75 RID: 11637
		private static readonly IntPtr NativeFieldInfoPtr_RESULT_OK;

		// Token: 0x04002D76 RID: 11638
		private static readonly IntPtr NativeFieldInfoPtr_OnConnectionFinished;

		// Token: 0x04002D77 RID: 11639
		private static readonly IntPtr NativeFieldInfoPtr_apis;

		// Token: 0x04002D78 RID: 11640
		private static readonly IntPtr NativeFieldInfoPtr_scopes;

		// Token: 0x04002D79 RID: 11641
		private static readonly IntPtr NativeFieldInfoPtr_connectionState;

		// Token: 0x04002D7A RID: 11642
		private static readonly IntPtr NativeFieldInfoPtr_shouldManageReconnection;

		// Token: 0x04002D7B RID: 11643
		private static readonly IntPtr NativeMethodInfoPtr_add_OnConnectionFinished_Public_add_Void_Action_1_ConnectionResult_0;

		// Token: 0x04002D7C RID: 11644
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnConnectionFinished_Public_rem_Void_Action_1_ConnectionResult_0;

		// Token: 0x04002D7D RID: 11645
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002D7E RID: 11646
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

		// Token: 0x04002D7F RID: 11647
		private static readonly IntPtr NativeMethodInfoPtr_AddApi_Public_Void_LoginApi_0;

		// Token: 0x04002D80 RID: 11648
		private static readonly IntPtr NativeMethodInfoPtr_AddScope_Public_Void_LoginScope_0;

		// Token: 0x04002D81 RID: 11649
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_0;

		// Token: 0x04002D82 RID: 11650
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Private_Void_0;

		// Token: 0x04002D83 RID: 11651
		private static readonly IntPtr NativeMethodInfoPtr_ConnectionResultHandler_Private_Void_String_0;

		// Token: 0x04002D84 RID: 11652
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionState_Public_get_ConnectionState_0;

		// Token: 0x04002D85 RID: 11653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003DF RID: 991
		[ObfuscatedName("SA.Fitness.Connection+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600394A RID: 14666 RVA: 0x000E84BC File Offset: 0x000E66BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Connection.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Connection>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Connection.__c>.NativeClassPtr);
				Connection.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection.__c>.NativeClassPtr, "<>9");
				Connection.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection.__c>.NativeClassPtr, "<>9__22_0");
				Connection.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection.__c>.NativeClassPtr, 100670522);
				Connection.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_Void_ConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection.__c>.NativeClassPtr, 100670523);
			}

			// Token: 0x0600394B RID: 14667 RVA: 0x000E8538 File Offset: 0x000E6738
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Connection.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600394C RID: 14668 RVA: 0x000E8574 File Offset: 0x000E6774
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__22_0(ConnectionResult <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_Void_ConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600394D RID: 14669 RVA: 0x000162F7 File Offset: 0x000144F7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D96 RID: 3478
			// (get) Token: 0x0600394E RID: 14670 RVA: 0x000E85B8 File Offset: 0x000E67B8
			// (set) Token: 0x0600394F RID: 14671 RVA: 0x00016300 File Offset: 0x00014500
			public unsafe static Connection.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Connection.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Connection.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Connection.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D97 RID: 3479
			// (get) Token: 0x06003950 RID: 14672 RVA: 0x000E85E0 File Offset: 0x000E67E0
			// (set) Token: 0x06003951 RID: 14673 RVA: 0x00016312 File Offset: 0x00014512
			public unsafe static Action<ConnectionResult> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Connection.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ConnectionResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Connection.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003379 RID: 13177
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400337A RID: 13178
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x0400337B RID: 13179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400337C RID: 13180
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__22_0_Internal_Void_ConnectionResult_0;
		}
	}
}
